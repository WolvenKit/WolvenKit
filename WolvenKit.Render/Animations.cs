using IrrlichtLime.Core;
using IrrlichtLime.Scene;
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Render
{
    public class Animations
    {
        public CommonData CData { get; set; }

        public Animations(CommonData cdata)
        {
            CData = cdata;
        }

        /// <summary>
        /// Read animations and animbuffers data.
        /// </summary>
        public void LoadData(CR2WFile animFile)
        {
            // *************** READ ANIMATION DATA ***************
            if (animFile != null)
            foreach (var chunk in animFile.chunks)
            {
                if (chunk.Type == "CAnimationBufferBitwiseCompressed")
                {
                    uint numFrames = (chunk.GetVariableByName("numFrames") as CUInt32).val;
                    float animDuration = (chunk.GetVariableByName("duration") as CFloat).val;
                    CData.animationSpeed = numFrames / animDuration;
                    uint keyFrame = 0;
                    byte[] data;
                    var deferredData = chunk.GetVariableByName("deferredData") as CInt16;
                    if (deferredData != null && deferredData.val != 0)
                        data = File.ReadAllBytes(animFile.FileName + "." + deferredData.val + ".buffer");
                    else
                        data = (chunk.GetVariableByName("data") as CByteArray).Bytes;
                    using (MemoryStream ms = new MemoryStream(data))
                    using (BinaryReader br = new BinaryReader(ms))
                    {
                        foreach (CVector bone in (chunk.GetVariableByName("bones") as CArray).array)
                        {
                            List<uint> currkeyframe = new List<uint>();
                            List<Quaternion> currorient = new List<Quaternion>();

                            br.BaseStream.Position = ((bone.GetVariableByName("orientation") as CVector).GetVariableByName("dataAddr") as CUInt32).val;
                            int orientNumFrames = ((bone.GetVariableByName("orientation") as CVector).GetVariableByName("numFrames") as CUInt16).val;
                            for (uint idx = 0; idx < orientNumFrames; idx++)
                            {
                                keyFrame = idx;
                                //keyFrame += numFrames;
                                currkeyframe.Add(keyFrame);
                                //bone.GetVariableByName("position");
                                byte[] odata = br.ReadBytes(6);
                                ulong bits = (ulong)odata[0] << 40 | (ulong)odata[1] << 32 | (ulong)odata[2] << 24 | (ulong)odata[3] << 16 | (ulong)odata[4] << 8 | odata[5];

                                ushort[] orients = new ushort[4];
                                float[] quart = new float[4];
                                orients[0] = (ushort)((bits & 0x0000FFF000000000) >> 36);
                                orients[1] = (ushort)((bits & 0x0000000FFF000000) >> 24);
                                orients[2] = (ushort)((bits & 0x0000000000FFF000) >> 12);
                                orients[3] = (ushort)((bits & 0x0000000000000FFF));

                                for (int i = 0; i < orients.Length; i++)
                                {
                                    float fVal = (2047.0f - orients[i]) * (1 / 2048.0f);
                                    quart[i] = fVal;
                                }
                                quart[3] = -quart[3];

                                currorient.Add(new Quaternion(quart[0], quart[1], quart[2], quart[3]));
                            }

                            CData.orientKeyframes.Add(currkeyframe);
                            CData.orientations.Add(currorient);

                            // TODO: Refactor
                            List<Vector3Df> currposition = new List<Vector3Df>();
                            currkeyframe = new List<uint>();
                            int compression = 0;
                            var compr = (bone.GetVariableByName("position") as CVector).GetVariableByName("compression") as CInt8;
                            if (compr != null)
                                compression = compr.val;
                            var addr = (bone.GetVariableByName("position") as CVector).GetVariableByName("dataAddr") as CUInt32;
                            if (addr != null)
                                br.BaseStream.Position = addr.val;
                            else
                                br.BaseStream.Position = 0;
                            var posNumFrames = ((bone.GetVariableByName("position") as CVector).GetVariableByName("numFrames") as CUInt16).val;
                            for (uint idx = 0; idx < posNumFrames; idx++)
                            {
                                keyFrame = idx;
                                //keyFrame += numFrames;
                                currkeyframe.Add(keyFrame);
                                var vec = new CVector3D();
                                vec.Read(br, compression);
                                Vector3Df pos = new Vector3Df(vec.x.val, vec.y.val, vec.z.val);
                                currposition.Add(pos);
                            }
                            CData.positionsKeyframes.Add(currkeyframe);
                            CData.positions.Add(currposition);

                            List<Vector3Df> currscale = new List<Vector3Df>();
                            currkeyframe = new List<uint>();
                            compression = 0;
                            compr = (bone.GetVariableByName("scale") as CVector).GetVariableByName("compression") as CInt8;
                            if (compr != null)
                                compression = compr.val;
                            addr = (bone.GetVariableByName("scale") as CVector).GetVariableByName("dataAddr") as CUInt32;
                            if (addr != null)
                                br.BaseStream.Position = addr.val;
                            else
                                br.BaseStream.Position = 0;
                            var scaleNumFrames = ((bone.GetVariableByName("scale") as CVector).GetVariableByName("numFrames") as CUInt16).val;
                            for (uint idx = 0; idx < scaleNumFrames; idx++)
                            {
                                keyFrame = idx;
                                //keyFrame += numFrames;
                                currkeyframe.Add(keyFrame);
                                var vec = new CVector3D();
                                vec.Read(br, compression);
                                Vector3Df scale = new Vector3Df(vec.x.val, vec.y.val, vec.z.val);
                                currscale.Add(scale);
                            }
                            CData.scalesKeyframes.Add(currkeyframe);
                            CData.scales.Add(currscale);
                        }
                    }
                    break;
                }
            }
        }

        /// <summary>
        /// Try to apply animation to model.
        /// </summary>
        public void Apply(SkinnedMesh skinnedMesh)
        {
            skinnedMesh.AnimationSpeed = CData.animationSpeed;
            for (int i = 0; i < CData.orientations.Count; i++)
            {
                SJoint joint = skinnedMesh.GetAllJoints()[i];
                for (int j = 0; j < CData.positions[i].Count; j++)
                {
                    var poskey = skinnedMesh.AddPositionKey(joint);
                    poskey.Position = CData.positions[i][j];
                    poskey.Frame = CData.positionsKeyframes[i][j];
                }

                for (int j = 0; j < CData.orientations[i].Count; j++)
                {
                    var rotkey = skinnedMesh.AddRotationKey(joint);
                    rotkey.Rotation = CData.orientations[i][j];
                    rotkey.Frame = CData.orientKeyframes[i][j];
                }

                for (int j = 0; j < CData.scales[i].Count; j++)
                {
                    var scalekey = skinnedMesh.AddScaleKey(joint);
                    scalekey.Scale = CData.scales[i][j];
                    scalekey.Frame = CData.scalesKeyframes[i][j];
                }
            }
        }
    }
}
