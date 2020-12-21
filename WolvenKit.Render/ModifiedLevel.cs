using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IrrlichtLime.Scene;
using IrrlichtLime.Core;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Render
{
    public class ModifiedLevel
    {
        public string DepotPath;
        public List<SceneNode> ModifiedNodes;

        public ModifiedLevel()
        {
            ModifiedNodes = new List<SceneNode>();
        }

        private void EulerToMatrix(float rx, float ry, float rz, CMatrix3x3 rm)
        {
            double sr = Math.Sin(rx);
            double cr = Math.Cos(rx);
            double sp = Math.Sin(ry);
            double cp = Math.Cos(ry);
            double sy = Math.Sin(rz);
            double cy = Math.Cos(rz);

            rm.ax.val = (float)(cp * cy);
            rm.ay.val = (float)(cp * sy);
            rm.az.val = (float)(-sp);

            double srsp = sr * sp;
            double crsp = cr * sp;

            rm.bx.val = (float)(srsp * cy - cr * sy);
            rm.by.val = (float)(srsp * sy + cr * cy);
            rm.bz.val = (float)(sr * cp);

            rm.cx.val = (float)(crsp * cy + sr * sy);
            rm.cy.val = (float)(crsp * sy - sr * cy);
            rm.cz.val = (float)(cr * cp);
        }

        public void Update()
        {
            float DEGREES_TO_RADIANS = (float)(Math.PI / 180.0);

            CR2WFile layer;
            using (var fs = new FileStream(DepotPath, FileMode.Open, FileAccess.Read))
            using (var reader = new BinaryReader(fs))
            {
                layer = new CR2WFile();
                layer.Read(reader);
                fs.Close();
            }

            // update all CSectorData objects
            foreach (var chunk in layer.Chunks)
            {
                if (chunk.REDType == "CSectorData")
                {
                    CSectorData sd = (CSectorData)chunk.data;

                    // only add sector node if there are meshes
                    foreach (var block in sd.BlockData)
                    {
                        if (block.packedObjectType == Enums.BlockDataObjectType.Mesh)
                        {
                            SBlockDataMeshObject mo = (SBlockDataMeshObject)block.packedObject;
                            ushort meshIndex = mo.meshIndex.val;
                            string meshName = Path.GetFileName(sd.Resources[meshIndex].pathHash.val);

                            foreach (SceneNode sn in ModifiedNodes)
                            {
                                string modifiedMeshName = Path.GetFileName(sn.Name);
                                if (meshName.Equals(modifiedMeshName))
                                {
                                    Vector3Df pos = sn.Position;
                                    Vector3Df rot = sn.Rotation;

                                    // update position and rotation
                                    block.position.X.val = -pos.X; // flip this
                                    block.position.Y.val = pos.Y;
                                    block.position.Z.val = pos.Z;

                                    float rx = rot.X * DEGREES_TO_RADIANS;
                                    float ry = rot.Y * DEGREES_TO_RADIANS;
                                    float rz = -rot.Z * DEGREES_TO_RADIANS; // flip this
                                    EulerToMatrix(rx, ry, rz, block.rotationMatrix);
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            using (var fs = new FileStream(DepotPath, FileMode.Open, FileAccess.ReadWrite))
            using (var writer = new BinaryWriter(fs))
            {
                layer.Write(writer);
                fs.Close();
            }
        }
    }

}
