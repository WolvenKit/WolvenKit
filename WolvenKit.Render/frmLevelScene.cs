//#define USE_WK_OCTREE

using Assimp;
using IrrlichtLime;
using IrrlichtLime.Core;
using IrrlichtLime.GUI;
using IrrlichtLime.IO;
using IrrlichtLime.Scene;
using IrrlichtLime.Video;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Dialogs.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.Common;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using WolvenKit.DDS;
using static WolvenKit.CR2W.Types.Enums;
using static WolvenKit.DDS.TexconvWrapper;

namespace WolvenKit.Render
{
    public partial class frmLevelScene : DockContent
    {
        public static float Clamp(float value, float min, float max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }

        private void MatrixToEuler(CMatrix3x3 rm, out float rx, out float ry, out float rz)
        {
            float r11 = rm.ax.val;
            float r12 = rm.ay.val;
            float r13 = rm.az.val;

            float r21 = rm.bx.val;
            float r22 = rm.by.val;
            float r23 = rm.bz.val;

            float r31 = rm.cx.val;
            float r32 = rm.cy.val;
            float r33 = rm.cz.val;

            float y = -(float)Math.Asin(Clamp(r13, -1.0f, 1.0f));
            float c = (float)Math.Cos(y);
            ry = y;
            if (Math.Abs(ry) >= Math.PI * 2.0)
            {
                ry = 0;
            }

            y *= (float)(180.0 / Math.PI);

            if (Math.Abs(c) > 0.0005f)
            {
                float invC = 1.0f / c;
                float rotx = r33 * invC;
                float roty = r23 * invC;
                rx = (float)Math.Atan2(roty, rotx);
                if (rx < 0)
                {
                    rx += (float)(Math.PI * 2.0);
                }

                rotx = r11 * invC;
                roty = r12 * invC;
                rz = (float)Math.Atan2(roty, rotx);
                if (rz < 0)
                {
                    rz += (float)(Math.PI * 2.0);
                }
            }
            else
            {
                rx = 0;
                rz = (float)Math.Atan2(-r21, r22);
                if (rz < 0)
                {
                    rz += (float)(Math.PI * 2.0);
                }
            }
        }

        /// <summary>
        /// Thread variable for irrlicht thread.
        /// </summary>
        private Thread irrThread;

        private IrrlichtDevice device;
        private VideoDriver driver;
        private SceneManager smgr;
        private GUIEnvironment gui;
        private GUIStaticText fpstext;
        private GUIStaticText vertexCountText;
        private int totalVertexCount = 0;

        private IrrlichtLime.Scene.SceneNode worldNode;
        private IrrlichtLime.Scene.SceneNode lightNode;

        private string inputFilename;
        private string depot;
        private int meshId;
        private bool doAddNodes;
        private Cache.TextureManager textureManager;

        public frmLevelScene(string filename, string depotPath, Cache.TextureManager textureManager)
        {
            this.inputFilename = filename;
            this.depot = depotPath + "\\";
            this.meshId = 1;
            this.doAddNodes = false;
            InitializeComponent();
            this.sceneView.Enabled = false;
        }

        private void AddLayer(string layerFileName, string layerName, ref int meshId)
        {
            float RADIANS_TO_DEGREES = (float)(180 / Math.PI);

            CR2WFile layer;
            using (var fs = new FileStream(layerFileName, FileMode.Open, FileAccess.Read))
            using (var reader = new BinaryReader(fs))
            {
                layer = new CR2WFile();
                layer.Read(reader);
                fs.Close();
            }

            TreeNode layerNode = new TreeNode(layerName);

            foreach (var chunk in layer.chunks)
            {
                if (chunk.REDType == "CSectorData")
                {
                    CSectorData sd = (CSectorData)chunk.data;

                    // only add sector node if there are meshes
                    bool atLeastOneMesh = false;

                    foreach (var block in sd.BlockData)
                    {
                        if (block.packedObjectType == Enums.BlockDataObjectType.Mesh)
                        {
                            SVector3D position = block.position;
                            CMatrix3x3 rot = block.rotationMatrix;
                            float rx, ry, rz;
                            MatrixToEuler(rot, out rx, out ry, out rz); // radians

                            Vector3Df rotation = new Vector3Df(rx * RADIANS_TO_DEGREES, ry * RADIANS_TO_DEGREES, -rz * RADIANS_TO_DEGREES);
                            Vector3Df translation = new Vector3Df(-position.X.val, position.Y.val, position.Z.val);

                            // now get mesh to apply this to!
                            SBlockDataMeshObject mo = (SBlockDataMeshObject)block.packedObject;
                            ushort meshIndex = mo.meshIndex.val;
                            if (meshIndex > sd.Resources.Count)
                            {
                                continue;
                            }
                            string meshName = sd.Resources[meshIndex].pathHash.val;

                            if (string.IsNullOrEmpty(meshName))
                            {
                                continue;
                            }
                            string meshPath = depot + meshName;

                            IrrlichtLime.Scene.Mesh m = smgr.GetMesh(meshPath);
#if USE_WK_OCTREE
                            // apply position and rotation!
                            
                            foreach (var mb in m.MeshBuffers)
                            {
                                totalVertexCount += mb.VertexCount;
                                mb.SetHardwareMappingHint(HardwareMappingHint.Static, HardwareBufferType.VertexAndIndex);
                            }
                            m = smgr.MeshManipulator.CreateMeshWithTangents(m, true);
#else
                            m = smgr.MeshManipulator.CreateMeshWithTangents(m, true);

                            foreach (var mb in m.MeshBuffers)
                            {
                                totalVertexCount += mb.VertexCount;
                                mb.SetHardwareMappingHint(HardwareMappingHint.Static, HardwareBufferType.VertexAndIndex);
                            }
#endif

                            RenderTreeNode meshNode = new RenderTreeNode(meshName, meshId++, m, translation, rotation);

                            sceneView.Invoke((MethodInvoker)delegate
                            {
                                if (!atLeastOneMesh)
                                {
                                    sceneView.Nodes.Add(layerNode);
                                    atLeastOneMesh = true;
                                }
                                layerNode.Nodes.Add(meshNode);
                            });
                        }
                    }
                }
            }
        }

        private void ParseScene()
        {
            //string meshPath = "D:/Tools/ModTools/r4data/environment/architecture/human/redania/novigrad/poor/poor_woodenfoof_loam/poor_woodenfoof_loam_roofb.w2mesh";
            //string meshPath = "D:/Tools/ModTools/r4data/environment/architecture/human/redania/novigrad/poor/poor_houses_parts/poor_frame_window_stone_g.w2mesh";
            //Mesh m = smgr.GetMesh(meshPath);

            //string imgPath = "D:/Tools/ModTools/r4data/fx/textures/cloud/stars_cubemap/stars2.w2cube";
            //Texture dudtex = driver.GetTexture(imgPath);

            /*
            string imgPath = "D:/Tools/ModTools/r4data/fx/textures/cloud/stars_cubemap/stars2.w2cube";
            Texture dudtex = driver.GetTexture(imgPath);

            CR2WFile imgAssetFile;
            using (var fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read))
            using (var reader = new BinaryReader(fs))
            {
                imgAssetFile = new CR2WFile();
                imgAssetFile.Read(reader);
                fs.Close();
            }
            CBitmapTexture xbm = ((CBitmapTexture)imgAssetFile.chunks[0].data);
            */

            //string meshPath = "D:/Tools/ModTools/r4data/engine/textures/editor/grey.xbm";
            //Mesh m = smgr.GetMesh(meshPath);
            //m = smgr.MeshManipulator.CreateMeshWithTangents(m, true);
            /*
            CR2WFile imgAssetFile;
            using (var fs = new FileStream(meshPath, FileMode.Open, FileAccess.Read))
            using (var reader = new BinaryReader(fs))
            {
                imgAssetFile = new CR2WFile();
                imgAssetFile.Read(reader);
                fs.Close();
            }

            Texture dudtex = driver.GetTexture(meshPath);
            */
            //===============================================

            if (Path.GetExtension(inputFilename) == ".w2w")
            {
                CR2WFile world;
                using (var fs = new FileStream(inputFilename, FileMode.Open, FileAccess.Read))
                using (var reader = new BinaryReader(fs))
                {
                    world = new CR2WFile();
                    world.Read(reader);
                    fs.Close();
                }

                foreach (var worldChunk in world.chunks)
                {
                    if (worldChunk.REDType == "CLayerInfo")
                    {
                        CLayerInfo info = (CLayerInfo)worldChunk.data;
                        string layerFileName = depot + info.DepotFilePath;

                        AddLayer(layerFileName, info.DepotFilePath.ToString(), ref meshId);
                    }
                }
            }
            else if(Path.GetExtension(inputFilename) == ".w2l")
            {
                AddLayer(inputFilename, inputFilename, ref meshId);
            }
        }

        /// <summary>
        /// Starts an irrlicht thread.
        /// </summary>
        private void StartIrrThread()
        {
            ThreadStart irrThreadStart = new ThreadStart(StartIrr);
            irrThread = new Thread(irrThreadStart);
            irrThread.IsBackground = true;
            irrThread.Start();
        }

        /// <summary>
        /// Restarts an irrlicht thread.
        /// </summary>
        private void RestartIrrThread()
        {
            irrThread.Abort();
            // restart an irrlicht thread
            StartIrrThread();
        }

        /// <summary>
        /// The irrlicht thread for rendering.
        /// </summary>
        private void StartIrr()
        {
            try
            {
                //Setup
                IrrlichtCreationParameters irrparam = new IrrlichtCreationParameters();
                if (irrlichtPanel.IsDisposed)
                    throw new Exception("Form closed!");
                if (irrlichtPanel.InvokeRequired)
                    irrlichtPanel.Invoke(new MethodInvoker(delegate { irrparam.WindowID = irrlichtPanel.Handle; }));
                irrparam.DriverType = DriverType.Direct3D9;
                irrparam.BitsPerPixel = 16;

                device = IrrlichtDevice.CreateDevice(irrparam);

                if (device == null) throw new NullReferenceException("Could not create device for engine!");

                driver = device.VideoDriver;
                smgr = device.SceneManager;
                gui = device.GUIEnvironment;

                smgr.Attributes.SetValue("TW_TW3_TEX_PATH", depot);
                driver.SetTextureCreationFlag(TextureCreationFlag.Always32Bit, true);

                lightNode = smgr.AddLightSceneNode(null, new Vector3Df(0, 0, 0), new Colorf(1.0f, 1.0f, 1.0f), 2000);
                smgr.AmbientLight = new Colorf(0.3f, 0.3f, 0.3f);
                worldNode = smgr.AddEmptySceneNode();
                worldNode.Rotation = new Vector3Df(-90, 0, 0);
                worldNode.Visible = true;

                var dome = smgr.AddSkyDomeSceneNode(driver.GetTexture("Terrain\\skydome.jpg"), 16, 8, 0.95f, 2.0f);
                dome.Visible = true;
                
                fpstext = gui.AddStaticText("0 fps",
                    new Recti(2, 10, 200, 30), false, false, null, 1, false);
                fpstext.OverrideColor = IrrlichtLime.Video.Color.SolidRed;

                ParseScene();

                vertexCountText = gui.AddStaticText(totalVertexCount.ToString() + " vertices",
                    new Recti(2, 32, 300, 52), false, false, null, 1, false);
                vertexCountText.OverrideColor = IrrlichtLime.Video.Color.SolidRed;

                smgr.AddCameraSceneNodeMaya();

                sceneView.Invoke((MethodInvoker)delegate
                {
                    this.sceneView.Enabled = true;
                });

                toolStrip.Invoke((MethodInvoker)delegate
                {
                    addMeshButton.Enabled = true;
                });

                while (device.Run())
                {
                    if(doAddNodes)
                    {
                        AddLayer(inputFilename, inputFilename, ref meshId);
                        doAddNodes = false;
                        sceneView.Invoke((MethodInvoker)delegate
                        {
                            this.sceneView.Enabled = true;
                        });
                    }
                    driver.BeginScene(ClearBufferFlag.All, new IrrlichtLime.Video.Color(0, 0, 100));
                    int val = driver.FPS;
                    fpstext.Text = val.ToString() + "fps";
                    smgr.DrawAll();
                    gui.DrawAll();
                    driver.EndScene();
                }
            }
            catch (ThreadAbortException) { }
            catch (NullReferenceException) { }
            catch (Exception ex)
            {
                if (!this.IsDisposed)
                {
                    MessageBox.Show(ex.Message);
                    //this.Invoke(new MethodInvoker(delegate { this.Close(); }));
                }
            }
        }

        private void frmLevelScene_Load(object sender, EventArgs e)
        {
            StartIrrThread();
        }

        private void irrlichtPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(device != null)
            {
                MouseEventType mev = MouseEventType.Move;
                uint buttonStates = 0;

                if (e.Button == MouseButtons.Left)
                {
                    buttonStates = 1;
                }
                else if (e.Button == MouseButtons.Right)
                {
                    buttonStates = 2;
                }
                else if (e.Button == MouseButtons.Middle)
                {
                    buttonStates = 4;
                }

                float wheel = e.Delta;
                Event evt = new Event(mev, e.X, e.Y, wheel, buttonStates);
                if(device.PostEvent(evt))
                {
                    lightNode.Position = smgr.ActiveCamera.Position;
                }
            }
        }

        private void irrlichtPanel_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void frmLevelScene_KeyDown(object sender, KeyEventArgs e)
        {
            var cam = smgr.ActiveCamera;
            float cameraspeed = 1f;
            switch (e.KeyCode)
            {
                case Keys.Escape:
                {
                    device.Close();
                    irrThread.Abort();
                    this.Close();
                    break;
                }
                case Keys.W:
                {
                    var vec = (cam.Target - cam.Position).Normalize() * cameraspeed;
                    cam.Position += vec;
                    cam.Target += vec;
                    break;
                }
                case Keys.S:
                {
                    var vec = (cam.Target - cam.Position).Normalize() * cameraspeed;
                    cam.Position -= vec;
                    cam.Target -= vec;
                    break;
                }
                case Keys.A:
                {
                    var vec = (cam.Target - cam.Position).Normalize().DotProduct(cam.Target.Normalize()) * cameraspeed;
                    cam.Position -= vec;
                    cam.Target -= vec;
                    break;
                }
                case Keys.D:
                {
                    var vec = (cam.Target - cam.Position).Normalize().DotProduct(cam.Target.Normalize()) *cameraspeed;
                    cam.Position += vec;
                    cam.Target += vec;
                    break;
                }
                case Keys.P:
                {
                    Console.WriteLine("--------- DEBUG ---------");
                    Console.WriteLine($"[DEBUG] Camera position - (X - {cam.Position.X}, Y - {cam.Position.Y}, Z - {cam.Position.Z})");
                    Console.WriteLine("--------- DEBUG ---------");
                    break;
                }
                case Keys.Q:
                {
                    break;
                }
            }
            lightNode.Position = cam.Position;
        }

        private void irrlichtPanel_Click(object sender, EventArgs e)
        {
        }

        private void Render(RenderTreeNode node)
        {
            if (node.MeshNode == null)
            {
#if USE_WK_OCTREE
                MeshSceneNode meshNode = smgr.AddOctreeSceneNode(node.Mesh, worldNode, node.ID);
#else
                MeshSceneNode meshNode = smgr.AddMeshSceneNode(node.Mesh, worldNode, node.ID, node.Position, node.Rotation);
#endif
                meshNode.AutomaticCulling = CullingType.FrustumBox;
                meshNode.SetMaterialFlag(MaterialFlag.Lighting, true);
                node.MeshNode = meshNode;
            }

            // otherwise the node is already in the scene so just put it in camera focus
            node.MeshNode.Visible = true;
            var camera = smgr.ActiveCamera;


            // for a Maya camera just set the target
            camera.Target = new Vector3Df(node.MeshNode.AbsolutePosition);
            lightNode.Position = camera.Position;
        }

        private void Hide(RenderTreeNode node)
        {
            node.MeshNode.Visible = false;
        }

        private void ExportTexture(string fileName, Texture tex)
        {
            // TODO: allow DXT1 and DTX5 images in memory and then decompress for conversion and export
            if(!IrrlichtLime.Video.Image.IsCompressedFormat(tex.ColorFormat))
            {
                IrrlichtLime.Video.Image img = driver.CreateImage(tex);
                driver.WriteImage(img, fileName);
                img.Drop();
            }
        }

        private void ExportNode(RenderTreeNode node, string exportMeshDirectory, string modelExtension, string texExtension, bool transformToWorld, string instanceName)
        {
            string meshNameOnly = Path.GetFileNameWithoutExtension(node.FullPath);
            string filename = exportMeshDirectory + "\\" + meshNameOnly + instanceName + modelExtension;

            // export textures too!
            foreach (var mb in node.Mesh.MeshBuffers)
            {
                if (mb.Material.GetTexture(0) != null)
                {
                    string tname = mb.Material.GetTexture(0).Name.ToString();
                    tname = tname.Replace(".xbm", texExtension);
                    tname = exportMeshDirectory + "\\" + Path.GetFileName(tname);

                    ExportTexture(tname, mb.Material.GetTexture(0));
                }

                if (mb.Material.GetTexture(1) != null)
                {
                    string tname = mb.Material.GetTexture(1).Name.ToString();
                    tname = tname.Replace(".xbm", texExtension);
                    tname = exportMeshDirectory + "\\" + Path.GetFileName(tname);

                    ExportTexture(tname, mb.Material.GetTexture(1));
                }
            }

            if (modelExtension == ".obj")
            {
                var mw = smgr.CreateMeshWriter(MeshWriterType.Obj);
                if (transformToWorld)
                {
                    Matrix localToWorld = new Matrix(node.Position, node.Rotation);
                    mw.SetTransform(localToWorld);
                }
                mw.SetImageType(texExtension);
                mw.WriteMesh(device.FileSystem.CreateWriteFile(filename), node.Mesh, MeshWriterFlag.None);
                mw.Drop();
            }
            else if (modelExtension == ".fbx")
            {
                var mw = smgr.CreateMeshWriter(MeshWriterType.Fbx);
                if (transformToWorld)
                {
                    Matrix localToWorld = new Matrix(node.Position, node.Rotation);
                    mw.SetTransform(localToWorld);
                }
                mw.SetImageType(texExtension);
                mw.WriteMesh(device.FileSystem.CreateWriteFile(filename), node.Mesh, MeshWriterFlag.None);
                mw.Drop();
            }
        }

        private void AddOpenFileDialogCustomControls(CommonFileDialog openDialog)
        {
            // Add a geometry type ComboBox
            CommonFileDialogGroupBox geoBox = new CommonFileDialogGroupBox("Geometry");
            CommonFileDialogComboBox geoComboBox = new CommonFileDialogComboBox("geoComboBox");
            geoComboBox.Items.Add(new CommonFileDialogComboBoxItem(".fbx"));
            geoComboBox.Items.Add(new CommonFileDialogComboBoxItem(".obj"));
            geoComboBox.SelectedIndex = 1;
            geoBox.Items.Add(geoComboBox);
            openDialog.Controls.Add(geoBox);

            // Add a texture ComboBox
            CommonFileDialogGroupBox texBox = new CommonFileDialogGroupBox("Texture");
            CommonFileDialogComboBox texComboBox = new CommonFileDialogComboBox("texComboBox");
            texComboBox.Items.Add(new CommonFileDialogComboBoxItem(".bmp"));
            texComboBox.Items.Add(new CommonFileDialogComboBoxItem(".jpg"));
            texComboBox.Items.Add(new CommonFileDialogComboBoxItem(".png"));
            texComboBox.Items.Add(new CommonFileDialogComboBoxItem(".tga"));
            texComboBox.SelectedIndex = 2;
            texBox.Items.Add(texComboBox);
            openDialog.Controls.Add(texBox);

            // Create and add a separator
            openDialog.Controls.Add(new CommonFileDialogSeparator());

            // Add a world or local space option
            openDialog.Controls.Add(new CommonFileDialogCheckBox("worldSpaceCheckBox", "World Space", false));

            // Add a multiple objects or single merged object
            openDialog.Controls.Add(new CommonFileDialogCheckBox("mergeCheckBox", "Merge", false));
        }

        private void Export(TreeNode node)
        {
            // OBJ for now
            var dlg = new CommonOpenFileDialog() { Title = "Select export folder" };
            dlg.IsFolderPicker = true;
            AddOpenFileDialogCustomControls(dlg);

            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string exportMeshDirectory = dlg.FileName;

                CommonFileDialogComboBox geoComboBox = dlg.Controls["geoComboBox"] as CommonFileDialogComboBox;
                string modelExtension = geoComboBox.Items[geoComboBox.SelectedIndex].Text;

                CommonFileDialogComboBox texComboBox = dlg.Controls["texComboBox"] as CommonFileDialogComboBox;
                string texExtension = texComboBox.Items[texComboBox.SelectedIndex].Text;

                CommonFileDialogCheckBox worldSpaceCheckBox = dlg.Controls["worldSpaceCheckBox"] as CommonFileDialogCheckBox;
                bool transformToWorld = worldSpaceCheckBox.IsChecked;

                CommonFileDialogCheckBox mergeCheckBox = dlg.Controls["mergeCheckBox"] as CommonFileDialogCheckBox;
                bool mergeObjects = mergeCheckBox.IsChecked;

                if (node.Nodes.Count > 0)
                {
                    // TODO: if merging is desired, combine all the objects into one mesh with multiple buffers
                    int instance = 0;                    
                    foreach(RenderTreeNode rn in node.Nodes)
                    {
                        string instanceName = "_" + instance.ToString();
                        ExportNode(rn, exportMeshDirectory, modelExtension, texExtension, transformToWorld, instanceName);
                        ++instance;
                    }
                }
                else
                {
                    string instanceName = "";
                    ExportNode((RenderTreeNode)node, exportMeshDirectory, modelExtension, texExtension, transformToWorld, instanceName);
                }
            }
        }

        private void irrlichtPanel_Enter(object sender, EventArgs e)
        {
            if (device != null)
            {
                if (device.CursorControl != null)
                {
                    device.CursorControl.Visible = false;
                }
            }
        }

        private void irrlichtPanel_Leave(object sender, EventArgs e)
        {
            if (device != null)
            {
                if (device.CursorControl != null)
                {
                    device.CursorControl.Visible = true;
                }
            }
        }

        private void sceneView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Checked)
            {
                if (node.Nodes.Count > 0)
                {
                    foreach (RenderTreeNode n in node.Nodes)
                    {
                        n.Checked = true;
                        Render(n);
                    }
                }
                else
                {
                    Render((RenderTreeNode)node);
                }
            }
            else
            {
                if (node.Nodes.Count > 0)
                {
                    foreach (RenderTreeNode n in node.Nodes)
                    {
                        n.Checked = false;
                        Hide(n); 
                    }                    
                }
                else
                {
                    Hide((RenderTreeNode)node);
                }
            }
        }

        private void addMeshButton_Click(object sender, EventArgs e)
        {
            var dlg = new CommonOpenFileDialog() { Title = "Select W2L file" };
            dlg.Multiselect = false;
            dlg.Filters.Add(new CommonFileDialogFilter("W2L Files", ".w2l"));
            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                inputFilename = dlg.FileName;
                doAddNodes = true;
                sceneView.Enabled = false;
            }
        }
        private void exportMeshButton_Click(object sender, EventArgs e)
        {
            // get selected nodes
            TreeNode node = sceneView.SelectedNode;
            Export(node);
        }

        private void sceneView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            exportMeshButton.Enabled = sceneView.SelectedNode != null;
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            foreach(TreeNode node in sceneView.Nodes)
            {
                node.Checked = true;
                foreach (RenderTreeNode n in node.Nodes)
                {
                    n.Checked = true;
                    Render(n);
                }
            }

        }

        private void irrlichtPanel_Resize(object sender, EventArgs e)
        {
            if (smgr != null)
            {
                var camera = smgr.ActiveCamera;
                if (camera != null)
                {
                    camera.AspectRatio = (float)irrlichtPanel.Width / (float)irrlichtPanel.Height;
                }
            }
        }
    }
}
