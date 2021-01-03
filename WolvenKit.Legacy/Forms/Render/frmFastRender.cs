using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.Common.Services;
using IrrlichtLime;
using IrrlichtLime.Core;
using IrrlichtLime.Video;
using IrrlichtLime.Scene;
using System.ComponentModel;
using System.Collections.Generic;
//using Microsoft.FSharp.Data.UnitSystems.SI.UnitNames;
using WolvenKit.Common;
using System.IO;
using IrrlichtLime.GUI;
using System.Runtime.InteropServices;
using MessageBoxButtons = System.Windows.Forms.MessageBoxButtons;
using MessageBoxIcon = System.Windows.Forms.MessageBoxIcon;

namespace WolvenKit.Render.FastRender
{
    public partial class frmFastRender : DockContent
    {
        public frmFastRender(String meshF, ILoggerService logger, W3Mod actMod )
        {
            InitializeComponent();
            Logger = logger;
            meshFile = meshF;
			activeMod = actMod;

        }

		class DeviceSettings : IrrlichtCreationParameters
		{
			public Color BackColor; // "null" for skybox

			public DeviceSettings(IntPtr hh, DriverType dt, byte aa, Color bc, bool vs)
			{
				WindowID = hh;
				DriverType = dt;
				AntiAliasing = aa;
				BackColor = bc;
				VSync = vs;
			}
		}

		public String meshFile;
        public String rigFile;
        public String animFile;

        private ILoggerService Logger;
		private W3Mod activeMod;
        private bool userWantExit = false; // if "true", we shut down rendering thread and then exit form

		private IrrlichtDevice dev = null;
		private VideoDriver drv = null;
		private SceneManager smgr = null;
		private GUIEnvironment gui;
		private Recti viewPort;

		private AnimatedMesh mesh = null;
		private AnimatedMeshSceneNode node = null;
		private MeshLoaderHelper helper = null;
		private SkinnedMesh meshToAnimate = null;	// mesh with rig loaded as base for animation

		private bool meshLoaded = false;
		private bool rigLoaded = false;
		private bool animLoaded = false;
		List<String> animList = null;
		private String activeAnim = "";

		private Vector3Df modelAngle = new Vector3Df(270.0f, 270.0f, 0.0f);
		private Vector3Df modelPosition = new Vector3Df(0.0f);

		private static float currCursorPosX = 0;
		private static float currCursorPosY = 0;

		private float scaleMul = 1.0f;


		private void frmFastRender_Load(object sender, EventArgs e)
		{
			initializeIrrlichtDevice();
		}


		private void initializeIrrlichtDevice()
        {

            // if rendering in progress, we are sending cancel request and waiting for its finishing
            if (backgroundRendering.IsBusy)
            {
                backgroundRendering.CancelAsync();
                while (backgroundRendering.IsBusy)
                    Application.DoEvents(); // this is not very correct way, but its very short, so we use it

                // redraw the panel, otherwise last rendered frame will stay as garbage
                panelRenderWindow.Invalidate();
            }
			
			backgroundRendering.RunWorkerAsync();
            if (Logger!=null)
				Logger.LogString("Initialize fast render...", Logtype.Normal);
        }

		private void backgroundRendering_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker worker = sender as BackgroundWorker;
			//DeviceSettings settings = e.Argument as DeviceSettings;

			// create irrlicht device using provided settings
			if (panelRenderWindow.IsDisposed)
				throw new Exception("Form closed!");

			DeviceSettings s = new DeviceSettings(
				IntPtr.Zero,
				DriverType.Direct3D9,
				0,  //antialias
				new Color(100, 101, 140),
				false);

			if (panelRenderWindow.InvokeRequired)
				panelRenderWindow.Invoke(new MethodInvoker(delegate { s.WindowID = panelRenderWindow.Handle; }));

			dev = IrrlichtDevice.CreateDevice(s);
			if (dev == null) throw new NullReferenceException("Could not create device for engine!");
			dev.OnEvent += new IrrlichtDevice.EventHandler(this.device_OnEvent);
			dev.Logger.LogLevel = LogLevel.Warning;

			drv = dev.VideoDriver;
			smgr = dev.SceneManager;
			gui = dev.GUIEnvironment;

			_ = smgr.FileSystem.AddFileArchive(activeMod.FileDirectory);

			smgr.Attributes.AddValue("TW_TW3_LOAD_SKEL", true);
			smgr.Attributes.AddValue("TW_TW3_LOAD_BEST_LOD_ONLY", true);


			// added by vl
			if (!string.IsNullOrEmpty(meshFile))
			{
				mesh = smgr.GetMesh(meshFile);
			}
			
			if (mesh == null)
				throw new Exception("Failed to load mesh.");

			mesh.Grab();
			smgr.MeshManipulator.RecalculateNormals(mesh);
			meshLoaded = true;

			float scaleMul = 1.0f;
			node = smgr.AddAnimatedMeshSceneNode(mesh);
			helper = smgr.GetMeshLoader(smgr.MeshLoaderCount - 1).getMeshLoaderHelper(); // hacked to gat witcher3 loader
			if (node != null && meshLoaded)
			{
				node.Scale = new Vector3Df(3.0f);
				node.SetMaterialFlag(MaterialFlag.Lighting, false);

				scaleMul = node.BoundingBox.Radius / 4;
				
				if (!string.IsNullOrEmpty(rigFile))
				{
					meshToAnimate = helper.loadRig(rigFile, mesh);
					if (meshToAnimate == null)
						throw new Exception("Failed to load rig.");
					else
					{
						meshToAnimate.Grab();
						rigLoaded = true;
						Logger.LogString("Rig loaded!", Logtype.Success);
						node.Mesh = meshToAnimate;
					}
				}

				if (!string.IsNullOrEmpty(animFile) && rigLoaded)
				{
					animList = helper.loadAnimation(animFile, meshToAnimate);
					if (animList.Count > 0)
					{
						animLoaded = true;
						Logger.LogString($"{animList.Count} animations loaded! Select animation to play", Logtype.Success);
					}
					else
						Logger.LogString("No animations loaded!", Logtype.Important);
				}

				setMaterialsSettings(node);
			}

			var camera = smgr.AddCameraSceneNode(	null,
													new Vector3Df(node.BoundingBox.Radius * 8, node.BoundingBox.Radius, 0),
													new Vector3Df(0, node.BoundingBox.Radius, 0)	);

			camera.NearValue = 0.001f;
			camera.FOV = 45.0f * 3.14f / 180.0f;


			var animText = activeAnim;

			var mAnimText = gui.AddStaticText(animText, new Recti(0, this.ClientSize.Height - 80, 100, this.ClientSize.Height - 70));
			var mPositionText = gui.AddStaticText("", new Recti(0, this.ClientSize.Height - 70, 100, this.ClientSize.Height - 60));
			var mRotationText = gui.AddStaticText("", new Recti(0, this.ClientSize.Height - 60, 100, this.ClientSize.Height - 50));
			var fpsText = gui.AddStaticText("", new Recti(0, this.ClientSize.Height - 50, 100, this.ClientSize.Height - 40));
			var infoText = gui.AddStaticText("[Space] - Reset\n[LMouse] - Rotate\n[MMouse] - Move\n[Wheel] - Zoom", new Recti(0, this.ClientSize.Height - 40, 100, this.ClientSize.Height));
			mAnimText.OverrideColor = mPositionText.OverrideColor = mRotationText.OverrideColor = fpsText.OverrideColor = infoText.OverrideColor = new Color(255, 255, 255);
			mAnimText.BackgroundColor = mPositionText.BackgroundColor = mRotationText.BackgroundColor = fpsText.BackgroundColor = infoText.BackgroundColor = new Color(0, 0, 0);

			viewPort = drv.ViewPort;
			var lineMat = new Material
			{
				Lighting = false
			};

			while (dev.Run())
			{
				drv.ViewPort = viewPort;

				drv.BeginScene(ClearBufferFlag.Depth | ClearBufferFlag.Color, s.BackColor);

				node.Position = modelPosition;
				node.Rotation = modelAngle;

				//update info box
				mPositionText.Text = $"X: {modelPosition.X.ToString("F2")} Y: {modelPosition.Y.ToString("F2")} Z: {modelPosition.Z.ToString("F2")}";
				mRotationText.Text = $"Yaw: {modelAngle.Y.ToString("F2")} Roll: {modelAngle.Z.ToString("F2")}";
				fpsText.Text = $"FPS: {drv.FPS}";

				smgr.DrawAll();
				gui.DrawAll();

				// draw xyz axis right bottom

				drv.ViewPort = new Recti(this.ClientSize.Width - 100, this.ClientSize.Height - 80, this.ClientSize.Width, this.ClientSize.Height);

				drv.SetMaterial(lineMat);
				var matrix = new Matrix(new Vector3Df(0, 0, 0), modelAngle);
				drv.SetTransform(TransformationState.World, matrix);
				matrix = matrix.BuildProjectionMatrixOrthoLH(100, 80, camera.NearValue, camera.FarValue);
				drv.SetTransform(TransformationState.Projection, matrix);
				matrix = matrix.BuildCameraLookAtMatrixLH(new Vector3Df(50, 0, 0), new Vector3Df(0, 0, 0), new Vector3Df(0, 1f, 0));
				drv.SetTransform(TransformationState.View, matrix);
				drv.Draw3DLine(0, 0, 0, 30f, 0, 0, Color.SolidGreen);
				drv.Draw3DLine(0, 0, 0, 0, 30f, 0, Color.SolidBlue);
				drv.Draw3DLine(0, 0, 0, 0, 0, 30f, Color.SolidRed);

				drv.EndScene();

				// if we requested to stop, we close the device
				if (worker.CancellationPending)
					dev.Close();
			}
			// drop device
			dev.Drop();
		}


		private void frmFastRender_FormClosing(object sender, FormClosingEventArgs e)
        {
            // if background worker still running, we send request to stop
            if (backgroundRendering.IsBusy)
            {
                backgroundRendering.CancelAsync();
                e.Cancel = true;
                userWantExit = true;
            }
			
        }

        private void backgroundRendering_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // if exception occured in rendering thread -- we display the message
            if (e.Error != null)
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			if (mesh != null)
				mesh.Drop();
			if (meshToAnimate != null)
				meshToAnimate.Drop();
			// if user want exit - we close main form
			// note: it is the only way to close form correctly -- only when device dropped,
			// so background worker not running
			if (userWantExit)
                Close();
			if (Logger != null)
				Logger.LogString("Fast rendering stopped.", Logtype.Normal);
        }

		private bool device_OnEvent(Event e)
		{
			if (e.Type == EventType.Log)
			{
				switch (e.Log.Level)
				{
					case LogLevel.Error:
						Logger.LogString(e.Log.Text, Logtype.Error);
						break;
					case LogLevel.Warning:
						Logger.LogString(e.Log.Text, Logtype.Important);
						break;
					default:
						Logger.LogString(e.Log.Text, Logtype.Normal);
						break;
				}
				return true;
			}
			return false;
		}

		private void panelRenderWindow_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				float deltaDirection = currCursorPosX - e.X;
				modelAngle.Y = (modelAngle.Y + deltaDirection / 4.0f) % 360.0f;
				if (modelAngle.Y < 0)
					modelAngle.Y = 360.0f + modelAngle.Y;

				// Around Z axis
				deltaDirection = currCursorPosY - e.Y;
				modelAngle.Z = (modelAngle.Z + deltaDirection / 20.0f) % 360.0f;
				if (modelAngle.Z < 0)
					modelAngle.Z = 360.0f + modelAngle.Z;
			}
			else if (e.Button == MouseButtons.Middle)
			{
				float deltaDirection = currCursorPosX - e.X;
				modelPosition.Z = modelPosition.Z - deltaDirection * scaleMul / 100;

				deltaDirection = currCursorPosY - e.Y;
				modelPosition.Y = modelPosition.Y + deltaDirection * scaleMul / 100;
			}
			else if (e.Delta > 0)
			{
				modelPosition.X = modelPosition.X + (float)e.Delta / 10.0f;
			}
			currCursorPosX = e.X;
			currCursorPosY = e.Y;
		}

		private void panelRenderWindow_MouseWheel(object sender, MouseEventArgs e)
		{
			modelPosition.X = modelPosition.X + (float)e.Delta / 25.0f;
		}

		private void loadRigToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Activate();
			var ofd = new OpenFileDialog();
			ofd.Filter = "Rig file|*.w2rig";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				rigFile = ofd.FileName;
				initializeIrrlichtDevice();
			}
		}

		private void loadAnimToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Activate();
			var ofd = new OpenFileDialog();
			ofd.Filter = "Animation file|*.w2anims";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				animFile = ofd.FileName;
				initializeIrrlichtDevice();
			}
		}

		private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
		{
			if (rigLoaded)
			{
				loadAnimToolStripMenuItem.Enabled = true;
			}
			if (animLoaded)
			{
				if (animList.Count > 0)
				{
					selectAnimationToolStripMenuItem.Enabled = true;
					selectAnimationToolStripMenuItem.DropDownItems.Clear();
					for (int i = 0; i < animList.Count; i++)
						selectAnimationToolStripMenuItem.DropDownItems.Add(animList[i]);
				}
			}
		}

		private void selectAnimationToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			node.DebugDataVisible = DebugSceneType.Off;

			SkinnedMesh sm = helper.applyAnimation(e.ClickedItem.Text, meshToAnimate);
			if (sm != null)
			{
				modelPosition = new Vector3Df(0.0f);
				modelAngle = new Vector3Df(0.0f);
				node.Mesh = sm;
				resetDebugViewMenu();
				setMaterialsSettings(node);
				activeAnim = e.ClickedItem.Text;
			}
		}

		private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (node.Type == SceneNodeType.AnimatedMesh)
			{
				(node as AnimatedMeshSceneNode).AnimationSpeed /= 2;
			}
		}

		private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (node.Type == SceneNodeType.AnimatedMesh)
			{
				(node as AnimatedMeshSceneNode).AnimationSpeed *= 1.75f;
			}
		}

		private void stopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (node.Type == SceneNodeType.AnimatedMesh)
			{
				(node as AnimatedMeshSceneNode).AnimationSpeed = 0;
			}
		}

		private void resetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (node.Type == SceneNodeType.AnimatedMesh)
			{
				(node as AnimatedMeshSceneNode).AnimationSpeed = mesh.AnimationSpeed;
			}
		}
		private void boundingBoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			boundingBoxToolStripMenuItem.Checked = !boundingBoxToolStripMenuItem.Checked;
			if (node != null)
			{
				node.DebugDataVisible ^= DebugSceneType.BBox;
			}
		}

		private void wireOverlayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			wireOverlayToolStripMenuItem.Checked = !wireOverlayToolStripMenuItem.Checked;
			if (node != null)
			{
				node.DebugDataVisible ^= DebugSceneType.MeshWireOverlay;
			}
		}

		private void skeletonToolStripMenuItem_Click(object sender, EventArgs e)
		{
			skeletonToolStripMenuItem.Checked = !skeletonToolStripMenuItem.Checked;
			if (node != null)
			{
				node.DebugDataVisible ^= DebugSceneType.Skeleton;
			}
		}
		private void halfTransparentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			halfTransparentToolStripMenuItem.Checked = !halfTransparentToolStripMenuItem.Checked;
			if (node != null)
			{
				node.DebugDataVisible ^= DebugSceneType.HalfTransparency;
			}
		}
		private void normalsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			normalsToolStripMenuItem.Checked = !normalsToolStripMenuItem.Checked;
			if (node != null)
			{
				node.DebugDataVisible ^= DebugSceneType.Normals;
			}
		}

		private void offToolStripMenuItem_Click(object sender, EventArgs e)
		{
			resetDebugViewMenu();
		}


		private void CheckMenuItem(ToolStripMenuItem item, bool check)
		{
			this.BeginInvoke(new MethodInvoker(delegate ()
			{
				item.Checked = check;
			}
			));
		}
		private void resetDebugViewMenu()
		{
			foreach (ToolStripMenuItem di in viewToolStripMenuItem.DropDownItems)
			{
				CheckMenuItem(di, false);
			}
			node.DebugDataVisible = DebugSceneType.Off;
		}

		private void exportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var sf = new SaveFileDialog())
			{
				sf.Filter = "Irrlicht mesh | *.irrm | Collada mesh | *.coll | STL Mesh | *.stl | OBJ Mesh | *.obj | PLY Mesh | *.ply | B3D Mesh | *.b3d | FBX Mesh | *.fbx";
				if (sf.ShowDialog() == DialogResult.OK)
				{
					MeshWriterType mwt = 0;
					switch (Path.GetExtension(sf.FileName).Trim())
					{
						case ".irrm":
							mwt = MeshWriterType.IrrMesh;
							break;
						case ".coll":
							mwt = MeshWriterType.Collada;
							break;
						case ".obj":
							mwt = MeshWriterType.Obj;
							break;
						case ".stl":
							mwt = MeshWriterType.Stl;
							break;
						case ".ply":
							mwt = MeshWriterType.Ply;
							break;
						case ".b3d":
							mwt = MeshWriterType.B3d;
							break;
						case ".fbx":
							mwt = MeshWriterType.Fbx;
							break;
						default:
							MessageBox.Show(this, "Wrong file format selected, choose correct file format!", "WolvenKit", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;

					}
					var mw = smgr.CreateMeshWriter(mwt);
					AnimatedMesh sm = mesh;
					SkinnedMesh s = null;
					if (meshToAnimate != null)
					{
						sm = meshToAnimate;
					}
					if (!string.IsNullOrEmpty(activeAnim))
					{
						s = helper.applyAnimation(activeAnim, meshToAnimate);
						if (s != null)
						{
							sm = s;
						}

					}

					if (mw.WriteMesh(dev.FileSystem.CreateWriteFile(sf.FileName), sm, MeshWriterFlag.None))
						MessageBox.Show(this, "Sucessfully wrote file!", "WolvenKit", MessageBoxButtons.OK, MessageBoxIcon.Information);
					else
						MessageBox.Show(this, "Failed to write file!", "WolvenKit", MessageBoxButtons.OK, MessageBoxIcon.Error);

					if(sm != null)
						sm.Drop();
					if (mw != null)
						mw.Drop();
					if (s != null)
						s.Drop();
				}
			}
		}

		private void setMaterialsSettings(AnimatedMeshSceneNode node)
		{
			if (node != null)
			{
				// materials with normal maps are not handled
				for (int i = 0; i < node.MaterialCount; ++i)
				{
					Material material = node.GetMaterial(i);
					if (material.Type == MaterialType.NormalMapSolid
						|| material.Type == MaterialType.ParallaxMapSolid)
					{
						material.Type = MaterialType.Solid;
					}
					else if (material.Type == MaterialType.NormalMapTransparentAddColor
						|| material.Type == MaterialType.ParallaxMapTransparentAddColor)
					{
						material.Type = MaterialType.TransparentAddColor;
					}
					else if (material.Type == MaterialType.NormalMapTransparentVertexAlpha
						|| material.Type == MaterialType.ParallaxMapTransparentVertexAlpha)
					{
						material.Type = MaterialType.TransparentVertexAlpha;
					}
				}

				node.SetMaterialFlag(MaterialFlag.Lighting, false);
				node.SetMaterialFlag(MaterialFlag.BackFaceCulling, false);

				for (int i = 1; i < 8; ++i) // 8 = _IRR_MATERIAL_MAX_TEXTURES_
					node.SetMaterialTexture(i, null);
			}
		}

	} // class

} // namespace
