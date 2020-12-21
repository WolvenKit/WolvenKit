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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.Common;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using static WolvenKit.CR2W.Types.Enums;
using static WolvenKit.Common.Tools.DDS.TexconvWrapper;

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

            double Y = -Math.Asin(Clamp(r13, -1.0f, 1.0f));
            double C = Math.Cos(Y);
            ry = (float)Y;

            double rotx, roty, X, Z;

            if (Math.Abs(C) > 0.0005)
            {
                double invC = 1.0 / C;
                rotx = r33 * invC;
                roty = r23 * invC;
                X = Math.Atan2(roty, rotx);
                rotx = r11 * invC;
                roty = r12 * invC;
                Z = Math.Atan2(roty, rotx);
            }
            else
            {
                X = 0.0;
                Z = Math.Atan2(-r21, r22);
            }

            rx = (float)X;
            rz = (float)Z;

            if (rx < 0)
            {
                rx += (float)(Math.PI * 2.0);
            }

            if (ry < 0)
            {
                ry += (float)(Math.PI * 2.0);
            }

            if (rz < 0)
            {
                rz += (float)(Math.PI * 2.0);
            }
        }

        /// <summary>
        /// Thread variable for irrlicht thread.
        /// </summary>
        private Thread irrThread;

        private IrrlichtDevice device;
        private VideoDriver driver;
        private SceneManagerWolvenKit smgr;
        private ConcurrentQueue<RenderMessage> commandQueue = new ConcurrentQueue<RenderMessage>();
        private GUIEnvironment gui;
        private GUIStaticText fpsText;
        private GUIStaticText vertexCountText;
        private GUIStaticText meshCountText;
        private int totalVertexCount = 0;
        private int totalMeshCount = 0;
        private MeshPropertyDialog propertiesDlg;

        private IrrlichtLime.Scene.SceneNode worldNode;
        private IrrlichtLime.Scene.SceneNode lightNode;
        private Recti viewPort;

        private string inputFilename;
        private readonly string depot;
        private int meshId;
        private bool pickKeyDown = false;

        private System.ComponentModel.BackgroundWorker backgroundLoader;
        private System.ComponentModel.BackgroundWorker backgroundSearcher;

        private void AddTerrain(CClipMap info, ref int meshId)
        {
            TreeNode terrainNode = new TreeNode("Terrain");

            float maxHeight = info.HighestElevation.val;
            float minHeight = info.LowestElevation.val;
            uint numTilesPerEdge = info.NumTilesPerEdge.val;
            float terrainSize = info.TerrainSize.val / numTilesPerEdge;

            uint tileRes = 0;
            int tileLOD = 0;

            Vector3Df startPoint = new Vector3Df(info.TerrainCorner.X.val, info.TerrainCorner.Y.val, info.TerrainCorner.Z.val);

            //string texFileName = info.Material.DepotPath; // this is a .w2mg
            //Texture terrainTex = driver.GetTexture("");
            Vector3Df nextRow = new Vector3Df(startPoint);
            Vector3Df dy = new Vector3Df(0.0f, terrainSize, 0.0f);
            Vector3Df dx = new Vector3Df(terrainSize, 0.0f, 0.0f);

            progressBar.Invoke((MethodInvoker)delegate
            {
                progressBar.Maximum = (int)(numTilesPerEdge * numTilesPerEdge);
            });

            int index = 0;
            for (uint y = 0; y < numTilesPerEdge; ++y)
            {
                Vector3Df nextColumn = new Vector3Df(startPoint + dy * y);

                for (uint x = 0; x < numTilesPerEdge; ++x)
                {
                    var tile = info.TerrainTiles[index++];
 
                    Vector3Df nextPt = new Vector3Df(nextColumn + dx * x);


                    // read the .wter file to get the LOD we need
                    {
                        var wterFileName = depot + tile.DepotPath;

                        CR2WFile wter;
                        using (var fs = new FileStream(wterFileName, FileMode.Open, FileAccess.Read))
                        using (var reader = new BinaryReader(fs))
                        {
                            wter = new CR2WFile();
                            wter.Read(reader);
                            fs.Close();
                        }

                        CTerrainTile crw = (CTerrainTile)wter.Chunks[0].data;
                        tileLOD = (int)crw.Groups[1].Lod1.val;
                        tileRes = (uint)crw.Groups[1].Resolution.val;
                    }

                    var tileFileName = tile.DepotPath;
                    tileFileName += ".";
                    tileFileName += tileLOD.ToString();
                    tileFileName += ".buffer";

                    RenderMessage message = new RenderMessage(MessageType.ADD_TERRAIN_NODE, tileFileName, tileRes, maxHeight, minHeight, terrainSize, nextPt, terrainNode);
                    commandQueue.Enqueue(message);

                    progressBar.Invoke((MethodInvoker)delegate
                    {
                        progressBar.PerformStep();
                    });

                }
            }
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

            foreach (var chunk in layer.Chunks)
            {
                if (chunk.REDType == "CSectorData")
                {
                    CSectorData sd = (CSectorData)chunk.data;

                    progressBar.Invoke((MethodInvoker)delegate
                    {
                        progressBar.Maximum = sd.BlockData.Count;
                    });

                    // only add sector node if there are meshes
                    foreach (var block in sd.BlockData)
                    {
                        if (block.packedObjectType == Enums.BlockDataObjectType.Mesh)
                        {
                            SVector3D position = block.position;
                            CMatrix3x3 rot = block.rotationMatrix;
                            float rx, ry, rz;
                            MatrixToEuler(rot, out rx, out ry, out rz); // radians

                            Vector3Df rotation = new Vector3Df(rx * RADIANS_TO_DEGREES, ry * RADIANS_TO_DEGREES, rz * RADIANS_TO_DEGREES);
                            Vector3Df translation = new Vector3Df(position.X.val, position.Y.val, position.Z.val);

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

                            RenderMessage message = new RenderMessage(MessageType.ADD_MESH_NODE, meshName, translation, rotation, layerNode);
                            commandQueue.Enqueue(message);

                            progressBar.Invoke((MethodInvoker)delegate
                            {
                                progressBar.PerformStep();
                            });
                        }
                    }
                }
            }
        }

        private bool LoadScene(BackgroundWorker worker, DoWorkEventArgs e)
        {
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

                foreach (var worldChunk in world.Chunks)
                {
                    if (worldChunk.REDType == "CLayerInfo")
                    {
                        CLayerInfo info = (CLayerInfo)worldChunk.data;
                        string layerFileName = depot + info.DepotFilePath;
                        AddLayer(layerFileName, info.DepotFilePath.ToString(), ref meshId);
                    }
                    else if (worldChunk.REDType == "CClipMap")
                    {
                        CClipMap info = (CClipMap)worldChunk.data;
                        AddTerrain(info, ref meshId);
                    }
                }

                // reset the progress bar
                progressBar.Invoke((MethodInvoker)delegate
                {
                    progressBar.Value = 0;
                });
            }
            else if (Path.GetExtension(inputFilename) == ".w2l")
            {
                AddLayer(inputFilename, inputFilename, ref meshId);

                // reset the progress bar
                progressBar.Invoke((MethodInvoker)delegate
                {
                    progressBar.Value = 0;
                });
            }

            return true;
        }

        private void LoadScene(object sender, DoWorkEventArgs e)
        {
            // Get the BackgroundWorker that raised this event.
            BackgroundWorker worker = sender as BackgroundWorker;

            e.Result = LoadScene(worker, e);
        }

        private void SceneLoaded(object sender, RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                // Next, handle the case where the user canceled 
                // the operation.
                // Note that due to a race condition in 
                // the DoWork event handler, the Cancelled
                // flag may not have been set, even though
                // CancelAsync was called.
                //resultLabel.Text = "Canceled";
            }
            else
            {
                // Finally, handle the case where the operation 
                // succeeded.
                //resultLabel.Text = e.Result.ToString();
            }

            toolStrip.Invoke((MethodInvoker)delegate
            {
                toolStrip.Items[0].Enabled = true; // add mesh
                toolStrip.Items[2].Enabled = true; // show all
            });
        }


        private TreeNode FindSceneNode(BackgroundWorker worker, DoWorkEventArgs e)
        {
            int id = (int)e.Argument;

            foreach(TreeNode tn in sceneView.Nodes)
            {
                foreach (RenderTreeNode rn in tn.Nodes)
                {
                    if (rn.MeshNode.ID == id)
                    {
                        return rn;
                    }
                }
            }

            return null;
        }

        private void SceneNodeFound(object sender, RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                // Next, handle the case where the user canceled 
                // the operation.
                // Note that due to a race condition in 
                // the DoWork event handler, the Cancelled
                // flag may not have been set, even though
                // CancelAsync was called.
                //resultLabel.Text = "Canceled";
            }
            else
            {
                // Finally, handle the case where the operation succeeded.
                if (e.Result != null)
                {
                    sceneView.SelectedNode = (TreeNode)e.Result;
                    sceneView.SelectedNode.Expand();

                    propertiesDlg.SetName(System.IO.Path.GetFileName(sceneView.SelectedNode.Text));
                }
            }
        }

        private void FindSceneNode(object sender, DoWorkEventArgs e)
        {
            // Get the BackgroundWorker that raised this event.
            BackgroundWorker worker = sender as BackgroundWorker;

            e.Result = FindSceneNode(worker, e);
        }

        public frmLevelScene(string filename, string depotPath, Cache.TextureManager textureManager)
        {
            this.inputFilename = filename;
            this.depot = depotPath + "\\";
            this.meshId = 1;
            InitializeComponent();

            this.showAllButton.Enabled = false;
            this.addMeshButton.Enabled = false;

            this.progressBar.Minimum = 0;
            this.progressBar.Maximum = 10;
            this.progressBar.Value = 0;
            this.progressBar.Step = 1;

            this.queueSizeBar.Minimum = 0;
            this.queueSizeBar.Maximum = 5000;
            this.queueSizeBar.Value = 0;
            this.queueSizeBar.Step = 1;

            this.distanceBar.Value = 3;

            this.rotateModeBtn.Enabled = false;
            this.translateModeBtn.Enabled = false;
            
            this.propertiesDlg = new MeshPropertyDialog();

            this.backgroundLoader = new System.ComponentModel.BackgroundWorker();
            this.backgroundLoader.DoWork += new DoWorkEventHandler(LoadScene);
            this.backgroundLoader.RunWorkerCompleted += new RunWorkerCompletedEventHandler(SceneLoaded);

            this.backgroundSearcher = new System.ComponentModel.BackgroundWorker();
            this.backgroundSearcher.DoWork += new DoWorkEventHandler(FindSceneNode);
            this.backgroundSearcher.RunWorkerCompleted += new RunWorkerCompletedEventHandler(SceneNodeFound);
        }

        private string GetNodeLevelName(SceneNode node)
        {
            foreach (TreeNode tn in sceneView.Nodes)
            {
                foreach (RenderTreeNode rn in tn.Nodes)
                {
                    if(rn.MeshNode == node)
                    {
                        return tn.Text;
                    }
                }
            }

            return null;
        }

        public bool CommitChanges()
        {
            // TODO: Show a status box with the files as they are saved since
            // this could take a while

            HashSet<SceneNode> modifications = propertiesDlg.GetModifiedNodes();
            Dictionary<string, ModifiedLevel> levels = new Dictionary<string, ModifiedLevel>();

            foreach(SceneNode n in modifications)
            {
                // get the .w2l file that the node belongs to
                string name = GetNodeLevelName(n);
                if(name != null)
                {
                    if(levels.TryGetValue(name, out ModifiedLevel lvl))
                    {
                        // already exists so just add this node
                        lvl.ModifiedNodes.Add(n);
                    }
                    else
                    {
                        // no level yet so make one
                        ModifiedLevel newLevel = new ModifiedLevel();
                        newLevel.DepotPath = name;
                        newLevel.ModifiedNodes.Add(n);
                        levels.Add(name, newLevel);
                    }
                }
            }

            // update all the files
            foreach(KeyValuePair<string, ModifiedLevel> entry in levels)
            {
                var confirmResult = MessageBox.Show($"Are you sure to overwrite this {entry.Value.DepotPath}?",
                                                   "Confirm Overwrite!",
                                                   MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    entry.Value.Update(); // Not yet working
                }
              
            }
            return true;
        }

        void ProcessCommand()
        {
            queueSizeBar.Invoke((MethodInvoker)delegate
            {
                if (commandQueue.Count > queueSizeBar.Maximum)
                {
                    queueSizeBar.Maximum = commandQueue.Count;
                    queueSizeBar.Value = queueSizeBar.Maximum;
                }
                else
                {
                    queueSizeBar.Value = commandQueue.Count;
                }
            });

            RenderMessage m;
            if (commandQueue.TryDequeue(out m))
            {
                switch (m.Message)
                {
                    case MessageType.SHOW_NODE:
                        {
                            m.Node.Visible = true;
                            var camera = smgr.ActiveCamera;

                            // just set the target
                            camera.Target = m.Node.AbsolutePosition;
                            lightNode.Position = camera.Position;
                        }
                        break;
                    case MessageType.HIDE_NODE:
                        {
                            m.Node.Visible = false;
                        }
                        break;
                    case MessageType.SELECT_NODE:
                        {
                            // highlight and 
                            smgr.SelectNode(m.Node);
                            var camera = smgr.ActiveCamera;

                            // just set the target
                            camera.Target = m.Node.AbsolutePosition;
                            lightNode.Position = camera.Position;
                        }
                        break;
                    case MessageType.ADD_MESH_NODE:
                        {
                            IrrlichtLime.Scene.Mesh mesh = smgr.GetStaticMesh(depot + m.MeshName);
                            foreach (var mb in mesh.MeshBuffers)
                            {
                                totalVertexCount += mb.VertexCount;
                            }
                            MeshSceneNode meshNode = smgr.AddMeshSceneNode(mesh, worldNode, meshId++, m.Translation, m.Rotation);
#if DEBUG
                            meshNode.Name = m.MeshName;
#endif
                            meshNode.Grab();

                            RenderTreeNode rn = new RenderTreeNode(m.MeshName, meshNode);
                            if (m.TreeNode.GetNodeCount(false) > 0)
                            {
                                // TODO: does this need to be invoked?
                                sceneView.Invoke((MethodInvoker)delegate
                                {
                                    m.TreeNode.Nodes.Add(rn);
                                });
                            }
                            else
                            {
                                sceneView.Invoke((MethodInvoker)delegate
                                {
                                    sceneView.Nodes.Add(m.TreeNode);
                                    m.TreeNode.Nodes.Add(rn);
                                });
                            }

                            ++totalMeshCount;

                            vertexCountText.Text = "Vertices: " + totalVertexCount.ToString();
                            meshCountText.Text = "Meshes: " + totalMeshCount.ToString();
                        }
                        break;
                    case MessageType.ADD_TERRAIN_NODE:
                        {
                            var meshNode = smgr.AddTerrainSceneNodeWolvenKit(depot + m.MeshName, worldNode, meshId, m.TileRes, m.MaxHeight, m.MinHeight, m.TerrainSize, m.Translation);
                            meshNode.Grab();
                            foreach (var mb in meshNode.Mesh.MeshBuffers)
                            {
                                totalVertexCount += mb.VertexCount;
                            }

                            RenderTreeNode rn = new RenderTreeNode("Tile " + meshId.ToString(), meshNode);
                            meshId++;

                            if (m.TreeNode.GetNodeCount(false) > 0)
                            {
                                // TODO: does this need to be invoked?
                                sceneView.Invoke((MethodInvoker)delegate
                                {
                                    m.TreeNode.Nodes.Add(rn);
                                });
                            }
                            else
                            {
                                sceneView.Invoke((MethodInvoker)delegate
                                {
                                    sceneView.Nodes.Add(m.TreeNode);
                                    m.TreeNode.Nodes.Add(rn);
                                });
                            }

                            ++totalMeshCount;

                            vertexCountText.Text = "Vertices: " + totalVertexCount.ToString();
                            meshCountText.Text = "Meshes: " + totalMeshCount.ToString();
                        }
                        break;
                    case MessageType.DESELECT_NODE:
                        {
                            smgr.DeselectNode();
                        }
                        break;
                    case MessageType.HIGHLIGHT_NODE:
                        {
                            smgr.SelectNode(m.Node);
                        }
                        break;
                    case MessageType.SHUTDOWN:
                        {
                            device.Yield();
                        }
                        break;
                    default:
                        break;
                }
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

            backgroundLoader.RunWorkerAsync();
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
#if DEBUG
            try
#endif
            {
                float DEGREES_TO_RADIANS = (float)(Math.PI / 180.0);

                //Setup
                IrrlichtCreationParameters irrparam = new IrrlichtCreationParameters();
                if (irrlichtPanel.IsDisposed)
                    throw new Exception("Form closed!");
                if (irrlichtPanel.InvokeRequired)
                    irrlichtPanel.Invoke(new MethodInvoker(delegate { irrparam.WindowID = irrlichtPanel.Handle; }));
                irrparam.DriverType = DriverType.Direct3D9;
                irrparam.BitsPerPixel = 32;
                irrparam.AntiAliasing = 1;

                device = IrrlichtDevice.CreateDevice(irrparam);

                if (device == null) throw new NullReferenceException("Could not create device for engine!");

                driver = device.VideoDriver;
                smgr = SceneManagerWolvenKit.Create(device);
                gui = device.GUIEnvironment;

                smgr.Attributes.SetValue("TW_TW3_TEX_PATH", depot);
                driver.SetTextureCreationFlag(TextureCreationFlag.Always32Bit, true);

                lightNode = smgr.AddLightSceneNode(null, new Vector3Df(0, 0, 0), new Colorf(1.0f, 1.0f, 1.0f), 200000.0f);
                smgr.AmbientLight = new Colorf(1.0f, 1.0f, 1.0f);
                worldNode = smgr.AddEmptySceneNode();
                //NOTE: Witcher assets use Z up but Irrlicht uses Y up so rotate the model
                worldNode.Rotation = new Vector3Df(-90, 0, 0);
                //NOTE: We also need to flip the x-coordinate with this rotation
                worldNode.Scale = new Vector3Df(-1.0f, 1.0f, 1.0f);
                worldNode.Visible = true;

                var dome = smgr.AddSkyDomeSceneNode(driver.GetTexture("Terrain\\skydome.jpg"), 16, 8, 0.95f, 2.0f);
                dome.Visible = true;
                
                fpsText = gui.AddStaticText("FPS: 0",
                    new Recti(2, 10, 200, 30), false, false, null, 1, false);
                fpsText.OverrideColor = IrrlichtLime.Video.Color.SolidRed;
                fpsText.OverrideFont = gui.GetFont("#DefaultWKFont");

                vertexCountText = gui.AddStaticText("Vertices: " + totalVertexCount.ToString(),
                    new Recti(2, 32, 300, 52), false, false, null, 1, false);
                vertexCountText.OverrideColor = IrrlichtLime.Video.Color.SolidRed;
                vertexCountText.OverrideFont = gui.GetFont("#DefaultWKFont");

                meshCountText = gui.AddStaticText("Meshes: " + totalMeshCount.ToString(),
                    new Recti(2, 54, 300, 74), false, false, null, 1, false);
                meshCountText.OverrideColor = IrrlichtLime.Video.Color.SolidRed;
                meshCountText.OverrideFont = gui.GetFont("#DefaultWKFont");

                var camera = smgr.AddCameraSceneNodeWolvenKit();
                camera.FarValue = 10000.0f;

                //distanceBar.Invoke((MethodInvoker)delegate
                //{
                //    camera.FarValue = (float)Math.Pow(10.0, (double)distanceBar.Value);
                //});

                viewPort = driver.ViewPort;
                var lineMat = new IrrlichtLime.Video.Material
                {
                    Lighting = false
                };

                var WMatrix = new Matrix(new Vector3Df(0, 0, 0), smgr.ActiveCamera.ModelRotation);

                var PMatrix = new Matrix();
                PMatrix = PMatrix.BuildProjectionMatrixOrthoLH(100, 80, 0.001f, 10000.0f);

                var VMatrix = new Matrix();
                VMatrix = VMatrix.BuildCameraLookAtMatrixLH(new Vector3Df(50, 0, 0), new Vector3Df(0, 0, 0), new Vector3Df(0, 1f, 0));

                int gizmoX = (int)(irrlichtPanel.Width * 0.92f);
                int gizmoY = (int)(irrlichtPanel.Height * 0.92f);
                var gizmoViewPort = new Recti(gizmoX, gizmoY, irrlichtPanel.Width, irrlichtPanel.Height);

                while (device.Run())
                {
                    if (this.Visible)
                    {
                        ProcessCommand();

                        driver.BeginScene(ClearBufferFlag.All);
                        int val = driver.FPS;
                        fpsText.Text = "FPS: " + val.ToString();

                        smgr.DrawAll();
                        gui.DrawAll();

                        // draw xyz axis right bottom
                        driver.ViewPort = gizmoViewPort;

                        driver.SetMaterial(lineMat);

                        WMatrix.SetRotationRadians(smgr.ActiveCamera.ModelRotation * DEGREES_TO_RADIANS);
                        driver.SetTransform(TransformationState.World, WMatrix);
                        driver.SetTransform(TransformationState.Projection, PMatrix);
                        driver.SetTransform(TransformationState.View, VMatrix);

                        driver.Draw3DLine(0, 0, 0, 30f, 0, 0, IrrlichtLime.Video.Color.SolidGreen);
                        driver.Draw3DLine(0, 0, 0, 0, 30f, 0, IrrlichtLime.Video.Color.SolidBlue);
                        driver.Draw3DLine(0, 0, 0, 0, 0, 30f, IrrlichtLime.Video.Color.SolidRed);

                        driver.ViewPort = viewPort;

                        driver.EndScene();
                    }
                    else
                        device.Yield();
                }
            }
#if DEBUG
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
#endif
        }

        private void frmLevelScene_Load(object sender, EventArgs e)
        {
            StartIrrThread();
        }

        private void irrlichtPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(device != null && smgr != null)
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
                smgr.PostEvent(evt);
                if (smgr.ActiveCamera != null)
                {
                    lightNode.Position = smgr.ActiveCamera.Position;
                }
            }
        }

        private void irrlichtPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            if (device != null)
            {
                MouseEventType mev = MouseEventType.Wheel;
                uint buttonStates = 7;
                float wheel = e.Delta;
                Event evt = new Event(mev, e.X, e.Y, wheel, buttonStates);
                smgr.PostEvent(evt);
                if (smgr.ActiveCamera != null)
                {
                    lightNode.Position = smgr.ActiveCamera.Position;
                }
            }
        }

        private void ExportTexture(string fileName, IrrlichtLime.Video.Texture tex)
        {
            IrrlichtLime.Video.Image img = null;
            if (IrrlichtLime.Video.Image.IsCompressedFormat(tex.ColorFormat))
            {
                img = driver.CreateUncompressedImage(tex);
            }
            else
            {
                img = driver.CreateImage(tex);
            }
            driver.WriteImage(img, fileName);
            img.Drop();
        }

        private void ExportNode(RenderTreeNode node, string exportMeshDirectory, string modelExtension, string texExtension, bool transformToWorld, string instanceName)
        {
            string meshNameOnly = Path.GetFileNameWithoutExtension(node.FullPath);
            string filename = exportMeshDirectory + "\\" + meshNameOnly + instanceName + modelExtension;

            // export textures too!
            if (node.MeshNode.GetType().Equals(typeof(MeshSceneNode)))
            {
                MeshSceneNode meshNode = (MeshSceneNode)node.MeshNode;
                foreach (var mb in meshNode.Mesh.MeshBuffers)
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
            }

            if (modelExtension == ".obj")
            {
                var mw = smgr.CreateMeshWriter(MeshWriterType.Obj);
                if (transformToWorld)
                {
                    Matrix localToWorld = new Matrix(node.MeshNode.Position, node.MeshNode.Rotation);
                    mw.SetTransform(localToWorld);
                }
                mw.SetImageType(texExtension);
                if (node.MeshNode.GetType().Equals(typeof(MeshSceneNode)))
                    mw.WriteMesh(device.FileSystem.CreateWriteFile(filename), ((MeshSceneNode)(node.MeshNode)).Mesh, MeshWriterFlag.None);
                else
                    mw.WriteMesh(device.FileSystem.CreateWriteFile(filename), ((TerrainSceneNodeWolvenKit)(node.MeshNode)).Mesh, MeshWriterFlag.None);
                mw.Drop();
            }
            else if (modelExtension == ".fbx")
            {
                var mw = smgr.CreateMeshWriter(MeshWriterType.Fbx);
                if (transformToWorld)
                {
                    Matrix localToWorld = new Matrix(node.MeshNode.Position, node.MeshNode.Rotation);
                    mw.SetTransform(localToWorld);
                }
                mw.SetImageType(texExtension);
                if (node.MeshNode.GetType().Equals(typeof(MeshSceneNode)))
                    mw.WriteMesh(device.FileSystem.CreateWriteFile(filename), ((MeshSceneNode)(node.MeshNode)).Mesh, MeshWriterFlag.None);
                //else
                //    mw.WriteMesh(device.FileSystem.CreateWriteFile(filename), ((TerrainSceneNodeWolvenKit)(node.MeshNode)).Mesh, MeshWriterFlag.None);
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

                exportMeshButton.Enabled = false;

                if (node.Nodes.Count > 0)
                {
                    // TODO: if merging is desired, combine all the objects into one mesh with multiple buffers
                    progressBar.Maximum = node.Nodes.Count;

                    int instance = 0;                    
                    foreach(RenderTreeNode rn in node.Nodes)
                    {
                        string instanceName = "_" + instance.ToString();
                        ExportNode(rn, exportMeshDirectory, modelExtension, texExtension, transformToWorld, instanceName);
                        ++instance;

                        progressBar.PerformStep();
                    }

                    progressBar.Value = 0;
                }
                else
                {
                    string instanceName = "";
                    ExportNode((RenderTreeNode)node, exportMeshDirectory, modelExtension, texExtension, transformToWorld, instanceName);
                }

                exportMeshButton.Enabled = true;
            }
        }

        private void irrlichtPanel_Enter(object sender, EventArgs e)
        {
            if (device != null)
            {
                if (device.CursorControl != null)
                {
                    device.CursorControl.Visible = true;
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
                        RenderMessage m = new RenderMessage(MessageType.SHOW_NODE, n.MeshNode);
                        commandQueue.Enqueue(m);
                    }
                }
                else
                {
                    RenderMessage m = new RenderMessage(MessageType.SHOW_NODE, ((RenderTreeNode)node).MeshNode);
                    commandQueue.Enqueue(m);
                }
            }
            else
            {
                if (node.Nodes.Count > 0)
                {
                    foreach (RenderTreeNode n in node.Nodes)
                    {
                        n.Checked = false;
                        RenderMessage m = new RenderMessage(MessageType.HIDE_NODE, n.MeshNode);
                        commandQueue.Enqueue(m);
                    }
                }
                else
                {
                    RenderMessage m = new RenderMessage(MessageType.HIDE_NODE, ((RenderTreeNode)node).MeshNode);
                    commandQueue.Enqueue(m);
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
                addMeshButton.Enabled = false;
                showAllButton.Enabled = false;

                backgroundLoader.RunWorkerAsync();
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
            // ignore parent nodes as they are just containers for the mesh nodes
            if (sceneView.SelectedNode.Nodes.Count > 0)
                return;

            if(sceneView.SelectedNode != null)
            {
                rotateModeBtn.Enabled = true;
                translateModeBtn.Enabled = true;

                exportMeshButton.Enabled = true;

                RenderTreeNode rn = (RenderTreeNode)sceneView.SelectedNode;
                RenderMessage message = new RenderMessage(MessageType.SELECT_NODE, rn.MeshNode);
                commandQueue.Enqueue(message);
            }
            else
            {
                rotateModeBtn.Enabled = false;
                translateModeBtn.Enabled = false;

                exportMeshButton.Enabled = false;
                RenderMessage message = new RenderMessage(MessageType.DESELECT_NODE);
                commandQueue.Enqueue(message);
            }

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {            
            progressBar.Maximum = sceneView.Nodes.Count;
            progressBar.Value = 0;

            foreach(TreeNode node in sceneView.Nodes)
            {
                node.Checked = true;
                foreach (RenderTreeNode n in node.Nodes)
                {
                    n.Checked = true;
                    RenderMessage message = new RenderMessage(MessageType.SHOW_NODE, n.MeshNode);
                    commandQueue.Enqueue(message);

                    progressBar.PerformStep();
                }
            }

            progressBar.Value = 0;
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

            propertiesDlg.Location = new Point(this.Location.X + this.Width - propertiesDlg.Width - 10, this.Location.Y + 30);
        }

        private void distanceBar_ValueChanged(object sender, EventArgs e)
        {
            if (smgr != null)
            {
                var camera = smgr.ActiveCamera;
                if (camera != null)
                {
                    camera.FarValue = Math.Max(10.0f, (float)Math.Pow(10.0, (double)distanceBar.Value));
                }
            }
        }

        private void progressBar_Resize(object sender, EventArgs e)
        {
            progressBar.Width = splitContainer.Panel2.Width - 2;
        }

        private void queueSizeBar_Resize(object sender, EventArgs e)
        {
            queueSizeBar.Width = splitContainer.Panel2.Width - 2;
        }

        private void frmLevelScene_KeyDown(object sender, KeyEventArgs e)
        {
            char keyChar;
            IrrlichtLime.KeyCode keyCode;

            switch (e.KeyCode)
            {
                case Keys.W:
                    {
                        // move camera forward
                        keyCode = KeyCode.KeyW;
                        keyChar = 'w';
                    }
                    break;
                case Keys.S:
                    {
                        // move camera back
                        keyCode = KeyCode.KeyS;
                        keyChar = 's';
                    }
                    break;
                case Keys.ControlKey:
                    {
                        pickKeyDown = true;
                        return;
                    }
                default:
                    return; // ignore
            }

            Event evt = new Event(keyChar, keyCode, true);
            smgr.PostEvent(evt);
            if (smgr.ActiveCamera != null)
            {
                lightNode.Position = smgr.ActiveCamera.Position;
            }
        }

        private void irrlichtPanel_MouseClick(object sender, MouseEventArgs e)
        {
            // need to have a click plus the ctrl key down
            if (pickKeyDown)
            {
                ViewFrustum f = smgr.ActiveCamera.ViewFrustum;

                Vector3Df farLeftUp = f.FarLeftUp;
                Vector3Df lefttoright = f.FarRightUp - farLeftUp;
                Vector3Df uptodown = f.FarLeftDown - farLeftUp;

                float dx = e.X / (float)viewPort.Width;
                float dy = e.Y / (float)viewPort.Height;

                Line3Df ray = new Line3Df(f.CameraPosition, farLeftUp + (lefttoright * dx) + (uptodown * dy));
                SceneNode pickedNode = smgr.SceneCollisionManager.GetSceneNodeFromRayBB(ray);

                if (pickedNode != null)
                {
                    RenderMessage message = new RenderMessage(MessageType.HIGHLIGHT_NODE, pickedNode);
                    commandQueue.Enqueue(message);

                    propertiesDlg.SetProperties(pickedNode);
                    if(!propertiesDlg.Visible)
                        propertiesDlg.Show(this);

                    if(backgroundSearcher.IsBusy)
                    {
                        backgroundSearcher.CancelAsync();
                    }
                    backgroundSearcher.RunWorkerAsync(pickedNode.ID);
                }
            }
        }

        private void frmLevelScene_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                pickKeyDown = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            CommitChanges();
        }
    }
}
