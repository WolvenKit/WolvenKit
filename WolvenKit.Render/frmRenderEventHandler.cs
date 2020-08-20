using System;
using IrrlichtLime;
using IrrlichtLime.Core;
using IrrlichtLime.Video;
using IrrlichtLime.Scene;
using IrrlichtLime.GUI;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using WolvenKit.Common.Services;

namespace WolvenKit.Render
{
    public partial class frmRender
    {
        #region event handlers
        private bool firstrun = true;
        private System.Windows.Forms.Timer resizeTimer = new System.Windows.Forms.Timer();
        private static bool renderStarted = true;
        private static float currCursorPosX = 0;
        private static float currCursorPosY = 0;

        /// <summary>
        /// setup visibility of render context menu
        /// </summary>
        private void setupRenderContextMenu()
        {
            if (rigFile != null)
            {
                if (animFile != null)
                {
                    selectAnimationToolStripMenuItem.DropDownItems.Clear();
                    for (int i = 0; i < Animations.AnimationNames.Count; i++)
                        selectAnimationToolStripMenuItem.DropDownItems.Add(Animations.AnimationNames[i].Key);
                    selectAnimationToolStripMenuItem.Enabled = true;
                }
                else
                {
                    loadAnimToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void ResizeTimer(object sender, EventArgs e)
        {
            resizeTimer.Stop();
            if (irrThread != null)
            {
                RestartIrrThread();
            }
        }


        private void irrlichtPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (renderStarted && e.Button == MouseButtons.Left)
            {
                modelAutorotating = false;
                // Around Y axis
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
            else if (renderStarted && e.Button == MouseButtons.Middle)
            {
                modelAutorotating = false;
                float deltaDirection = currCursorPosX - e.X;
                modelPosition.Z = modelPosition.Z - deltaDirection * scaleMul / 100;

                deltaDirection = currCursorPosY - e.Y;
                modelPosition.Y = modelPosition.Y + deltaDirection * scaleMul / 100;
            }
            else if (renderStarted && e.Delta > 0)
		    {
			    modelPosition.X = modelPosition.X + (float)e.Delta / 10.0f;
		    }
            currCursorPosX = e.X;
            currCursorPosY = e.Y;

            // This method should only work when the mouse is captured by the Form.
            // For instance, when the left mouse button is pressed:
            // It traps the mouse to be able to scroll infinitely
            /*if (!(e.Button == MouseButtons.Left || e.Button == MouseButtons.Right))
                return;

            Point p = PointToScreen(e.Location);
            int x = p.X;
            int y = p.Y;
            Rectangle bounds = this.Bounds;

            if (x <= bounds.Left + 1)
                x = bounds.Right - 10;
            else if (x >= bounds.Right - 9)
                x = bounds.Left + 2;

            if (y <= bounds.Top + 8)
                y = bounds.Bottom - 2;
            else if (y >= bounds.Bottom - 1)
                y = bounds.Top + 9;

            if (x != p.X || y != p.Y)
            {
                Cursor.Position = new Point(x, y);
                currentPosX = x - (bounds.Left + 1);
                currentPosY = y - (bounds.Top + 1);
            }*/
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (firstrun == false)
                resizeTimer.Start();
            else
                firstrun = false;
        }
        private bool device_OnEvent(Event e) // vl: not working, why????
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

        private void Bithack3D_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // Restart autorotation
                modelAutorotating = true;
                if (AnimFile == null)
                    modelAngle = new Vector3Df(startModelAngle.X, startModelAngle.Y, startModelAngle.Z);
                else
                    modelAngle = new Vector3Df(startModelAngleWithAnim.X, startModelAngleWithAnim.Y, startModelAngleWithAnim.Z);

                modelPosition = new Vector3Df(0.0f);
                currAnimIdx = -1;

            }
        }

        static bool OnKeyUp(KeyCode keyCode)
		{
			if (device == null)
            {
                return false;
            }

			switch (keyCode)
			{
				case KeyCode.KeyL:

					useLight = !useLight;
					if (node != null)
					{
                        Console.Write("L pressed."); // not working for some reasons???
						node.SetMaterialFlag(MaterialFlag.Lighting, useLight);
						node.SetMaterialFlag(MaterialFlag.NormalizeNormals, useLight);
					}

					break;
			}

			return false;
		} 
        
        private void viewToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if(skinnedMesh.JointCount != 0)
                skeletonToolStripMenuItem.Enabled = true;
            else
                skeletonToolStripMenuItem.Enabled = false;
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
        private void Bithack3D_MouseWheel(object sender, MouseEventArgs e)
        {
            if (renderStarted)
                modelPosition.X = modelPosition.X + (float)e.Delta / 1000.0f;
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
                    //if (mw.WriteMesh(device.FileSystem.CreateWriteFile(sf.FileName), cdata.staticMesh, MeshWriterFlag.None))
                    if (mw.WriteMesh(device.FileSystem.CreateWriteFile(sf.FileName), skinnedMesh, MeshWriterFlag.None))
                        MessageBox.Show(this, "Sucessfully wrote file!", "WolvenKit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(this, "Failed to write file!", "WolvenKit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loadRigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // HACK: Hacky (shit) solution for automatic path finding
            /*var basePath = doc.File.FileName.Split(new string[] { "characters" }, StringSplitOptions.None)[0];
            var modelName = Path.GetFileName(doc.File.FileName).Split('_', '.')[3];
            var rigPath = $@"{basePath}characters\base_entities\{modelName}_base\{modelName}_base.w2rig";*/
            if (MessageBox.Show("Could not find .w2rig for model!\nWould you like to search for the rig manually?", "Rig not found!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Activate();
                var ofd = new OpenFileDialog();
                ofd.Filter = "Rig file|*.w2rig";
                if (ofd.ShowDialog() == DialogResult.OK)
                    RigFile = LoadDocument(ofd.FileName);
            }
        }

        private void loadAnimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Could not find .w2anims for model!\nWould you like to search for the animation manually (highly experimental)?", "Animation not found!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Activate();
                var ofd = new OpenFileDialog();
                ofd.Filter = "Animation file|*.w2anims";
                //selectedAnimIdx = 0;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    AnimFile = LoadDocument(ofd.FileName);
                    MessageBox.Show("Animations loaded");
                }
            }
        }

        private void selectAnimationToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            node.DebugDataVisible = DebugSceneType.Off;
            currAnimIdx = Animations.AnimationNames.FindIndex(kv => kv.Key.Equals(e.ClickedItem.Text));
            anims.SelectAnimation(AnimFile, currAnimIdx);
            anims.Apply(skinnedMesh);

            modelPosition = new Vector3Df(0.0f);
            modelAngle = new Vector3Df(startModelAngleWithAnim.X, startModelAngleWithAnim.Y, startModelAngle.Z);

            RestartIrrThread();
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
                (node as AnimatedMeshSceneNode).AnimationSpeed *= 1.5f;
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
                (node as AnimatedMeshSceneNode).AnimationSpeed = skinnedMesh.AnimationSpeed;
            }
        }

        private void diffuseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Image (*.dds;*.bmp;*.jpg;*.jpeg;*.tga;*.png)|*.dds;*.bmp;*.jpg;*.jpeg;*.tga;*.png",
                Title = "Select diffuse texture"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Texture t = device.VideoDriver.GetTexture(ofd.FileName);
                if (t != null && node != null)
                {
                    // always reload texture
                    device.VideoDriver.RemoveTexture(t);
                    t = device.VideoDriver.GetTexture(ofd.FileName);
                    node.GetMaterial(0).SetTexture(0, t);
                }
            }
        }
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Image (*.dds;*.bmp;*.jpg;*.jpeg;*.tga;*.png)|*.dds;*.bmp;*.jpg;*.jpeg;*.tga;*.png",
                Title = "Select normal texture"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Texture t = device.VideoDriver.GetTexture(ofd.FileName);
                if (t != null && node != null)
                {
                    // always reload texture
                    device.VideoDriver.RemoveTexture(t);
                    t = device.VideoDriver.GetTexture(ofd.FileName);
                    node.GetMaterial(0).SetTexture(1, t);
                }
            }
        }
        private void resetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetMaterials(driver);
        }

        #endregion
    }
}
