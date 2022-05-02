using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;

using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;
using Quat = System.Numerics.Quaternion;
using Mat4 = System.Numerics.Matrix4x4;

namespace WolvenKit.ViewModels.Shell
{
    public partial class ChunkViewModel
    {
        public static Vec4 GetCenter(List<Vec4> poslist)
        {
            //minX + (maxX - minX)/2 == (maxX + minX)/2;
            var (minX, maxX) = (poslist.Select(_ => _.X).Min(), poslist.Select(_ => _.X).Max());
            var cX = (maxX + minX) / 2;

            var (minY, maxY) = (poslist.Select(_ => _.Y).Min(), poslist.Select(_ => _.Y).Max());
            var cY = (maxY + minY) / 2;

            var (minZ, maxZ) = (poslist.Select(_ => _.Z).Min(), poslist.Select(_ => _.Z).Max());
            var cZ = (maxZ + minZ) / 2;

            var (minW, maxW) = (poslist.Select(_ => _.W).Min(), poslist.Select(_ => _.W).Max());
            var cW = (maxW + minW) / 2;

            return new Vec4(cX, cY, cZ, cW);
        }

        public (List<Vec4>, List<Quat>) GetPosRot(List<Prop> props)
        {
            var poslist = new List<Vec4>();
            var rotlist = new List<Quat>();

            foreach (var line in props)
            {
                var posandrot = RedJsonSerializer.Deserialize<Vec7S>(PutQuotes(line.pos));
                var v = new Vec4()
                {
                    X = float.Parse(posandrot.x),
                    Y = float.Parse(posandrot.y),
                    Z = float.Parse(posandrot.z),
                    W = float.Parse(posandrot.w)
                };
                poslist.Add(v);

                var q = Quat.CreateFromYawPitchRoll(
                    (float)(Math.PI / 180) * float.Parse(posandrot.yaw),
                    (float)(Math.PI / 180) * float.Parse(posandrot.pitch),
                    (float)(Math.PI / 180) * float.Parse(posandrot.roll));
                q = FixRotation(q);

                rotlist.Add(q);
            }
            return (poslist, rotlist);
        }

        public (List<Vec4>, List<Quat>) GetPosRot(List<Child> props)
        {
            var poslist = new List<Vec4>();
            var rotlist = new List<Quat>();

            foreach (var line in props)
            {
                var pos = line.pos;
                var rot = line.rot;
                var v = new Vec4()
                {
                    X = pos.x,
                    Y = pos.y,
                    Z = pos.z,
                    W = pos.w
                };
                poslist.Add(v);

                var q = Quat.CreateFromYawPitchRoll(
                    (float)(Math.PI / 180) * rot.yaw,
                    (float)(Math.PI / 180) * rot.pitch,
                    (float)(Math.PI / 180) * rot.roll);
                q = FixRotation(q);

                rotlist.Add(q);
            }
            return (poslist, rotlist);
        }

        public static string PutQuotes(string w)
        {
            w = w.Replace("{", "{\"");
            w = w.Replace("}", "\"}");
            w = w.Replace(", ", "\",\"");
            w = w.Replace(" = ", "\":\"");
            return w;
        }

        public static Quat FixRotation(Quat q)
        {
            var rbcm = Mat4.Identity;
            rbcm.M22 = 0;
            rbcm.M23 = 1;
            rbcm.M32 = -1;
            rbcm.M33 = 0;

            var mq = Mat4.CreateFromQuaternion(q);
            Mat4.Invert(rbcm, out var irbcm);

            rbcm = irbcm * mq * rbcm;

            var q9 = Quat.CreateFromRotationMatrix(rbcm);

            //throw new Exception("boop");
            //(q.Z, q.Y) = (q.Y, q.Z);
            return q9;
        }

        public static List<Vec4> UpdateCoords(List<Vec4> poslist, Vec4 center)
        {
            for (var i = 0; i < poslist.Count; i++)
            {
                var pos = poslist[i];
                pos.X -= center.X;
                pos.Y -= center.Y;
                pos.Z -= center.Z;
                //pos.W -= center.W;
                poslist[i] = pos;
            }
            return poslist;
        }

        public void AddToData(worldNodeData current, string path, Vec4 pos, Quat rot)
        {
            if (Parent.Parent is not null &&
                Parent.Parent.Data is not null &&
                Parent.Parent.Data is worldStreamingSector wss)
            {
                var wen = new worldEntityNode();
                var wenh = new CHandle<worldNode>(wen);
                var index = wss.Nodes.Count;

                wen.EntityTemplate.DepotPath = path;
                ((IRedArray)wss.Nodes).Insert(index, (IRedType)wenh);

                current.Position.X += pos.X;
                current.Position.Y += pos.Y;
                current.Position.Z += pos.Z;
                current.Position.W *= pos.W;

                current.Orientation = rot;

                current.Pivot.X = current.Position.X;
                current.Pivot.Y = current.Position.Y;
                current.Pivot.Z = current.Position.Z;

                //definitely does not go to 5000
                current.MaxStreamingDistance = 5000;

                current.NodeIndex = (CUInt16)index;

                if (Parent.Data is DataBuffer db && db.Buffer.Data is IRedType irt)
                {
                    if (irt is IRedArray ira && ira.InnerType.IsAssignableTo(current.GetType()))
                    {
                        var indexx = Parent.GetIndexOf(this) + 1;
                        if (indexx == -1 || indexx > ira.Count)
                        {
                            indexx = ira.Count;
                        }
                        ira.Insert(indexx, (IRedType)current);
                    }
                }

            }
        }

        public List<Child> GetLines(Root1 json)
        {
            var props = new List<Child>();

            var v = new Child()
            {
                pos = json.pos,
                rot = json.rot,
                name = json.name
            };
            props.Add(v);

            foreach (var child in json.childs)
            {
                GetLines(child, props);
            }

            return props;
        }

        public void GetLines(Child c, List<Child> props)
        {
            var v = new Child()
            {
                pos = c.pos,
                rot = c.rot,
                name = c.name,
                path = c.path
            };
            props.Add(v);
            if (c.childs is not null)
            {
                foreach (var cc in c.childs)
                {
                    GetLines(cc, props);
                }
            }
        }
        public static Vec4 GetCenter(Root1 r)
        {
            return new Vec4(r.pos.x, r.pos.y, r.pos.z, r.pos.w);
        }
        public void Add00(List<Prop> props, string tr)
        {
            var (poslist, rotlist) = GetPosRot(props);
            var center = GetCenter(poslist);

            poslist = UpdateCoords(poslist, center);

            for (var i = 0; i < props.Count; i++)
            {
                var line = props[i];
                var current = RedJsonSerializer.Deserialize<worldNodeData>(tr);

                var scala = line.scale == "nil" ? null
                    : RedJsonSerializer.Deserialize<Vec3S>(PutQuotes(line.scale));
                if (scala is not null)
                {
                    current.Scale.X = float.Parse(scala.x) / 100;
                    current.Scale.Y = float.Parse(scala.y) / 100;
                    current.Scale.Z = float.Parse(scala.z) / 100;
                }

                AddToData(current, line.template_path, poslist[i], rotlist[i]);
            }
        }

        public void Add00(Root1 json, string tr)
        {
            var props = GetLines(json);
            var (poslist, rotlist) = GetPosRot(props);
            var center = GetCenter(json);

            poslist = UpdateCoords(poslist, center);

            for (var i = 0; i < props.Count; i++)
            {
                var line = props[i];
                var current = RedJsonSerializer.Deserialize<worldNodeData>(tr);

                AddToData(current, line.path, poslist[i], rotlist[i]);
            }
        }

        //OG version, gotta refactor that mess
        public void Add0_OG(Root0 json, string tr)
        {
            var poslist = new List<Vec4>();
            var rotlist = new List<Quat>();

            foreach (var line in json.props)
            {
                var posandrot = RedJsonSerializer.Deserialize<Vec7S>(PutQuotes(line.pos));
                var v = new Vec4()
                {
                    X = float.Parse(posandrot.x),
                    Y = float.Parse(posandrot.y),
                    Z = float.Parse(posandrot.z),
                    W = float.Parse(posandrot.w)
                };
                poslist.Add(v);

                if (float.Parse(posandrot.pitch) != 0)
                {
                    Console.Write(posandrot.pitch);
                }

                var q = Quat.CreateFromYawPitchRoll(
                    (float)(Math.PI / 180) * float.Parse(posandrot.yaw),
                    (float)(Math.PI / 180) * float.Parse(posandrot.pitch),
                    (float)(Math.PI / 180) * float.Parse(posandrot.roll));

                var angleindegrees = 90;

                var flipx = Quat.CreateFromAxisAngle(new Vec3(1, 0, 0), (float)(Math.PI / 180 * angleindegrees * 1));
                var flipy = Quat.CreateFromAxisAngle(new Vec3(0, 1, 0), (float)(Math.PI / 180 * angleindegrees * 1));
                var flipz = Quat.CreateFromAxisAngle(new Vec3(0, 0, 1), (float)(Math.PI / 180 * angleindegrees * 1));


                var t0 = Mat4.CreateFromYawPitchRoll(
                    (float)(Math.PI / 180) * float.Parse(posandrot.yaw),
                    (float)(Math.PI / 180) * float.Parse(posandrot.pitch),
                    (float)(Math.PI / 180) * float.Parse(posandrot.roll));


                Mat4.CreateReflection(new System.Numerics.Plane());

                var t1 = Mat4.CreateFromQuaternion(q);

                var tt = t0 == t1;

                var t9000 = Mat4.Identity;
                t9000.M11 = 1;
                t9000.M13 = 0;
                t9000.M21 = 0;
                t9000.M22 = 0;
                t9000.M23 = 1;
                //t9000.M31 = -1;
                t9000.M32 = -1;
                t9000.M33 = 0;

                var ttt = Mat4.CreateFromQuaternion(q);
                Mat4.Invert(t9000, out var i9000);


                var fuckx = Mat4.CreateRotationX((float)Math.PI / 2);
                var fucky = Mat4.CreateRotationY((float)Math.PI * 2 / 2);
                Mat4.Invert(fucky, out var ifucky);

                var fuckz = Mat4.CreateRotationY((float)Math.PI * 2 / 2);
                Mat4.Invert(fuckz, out var ifuckz);

                var t9001 = Mat4.Identity;

                t9001.M11 = 1;
                t9001.M22 = 1;
                t9001.M33 = -1;

                t9000 = i9000 * ifucky * ifuckz * ttt * fuckz * fucky * t9000;
                //fuckx = fuckx * fucky * ttt;
                fuckx = t9001 * ttt;

                var t00 = Mat4.CreateFromYawPitchRoll(
                    (float)(Math.PI / 180) * float.Parse(posandrot.roll),
                    (float)(Math.PI / 180) * float.Parse(posandrot.pitch),
                    (float)(Math.PI / 180) * float.Parse(posandrot.yaw)
                    );


                //var tt000 = q == q9;
                var q9 = Quat.CreateFromRotationMatrix(t9000);


                //q = flipy * q * Quat.Conjugate(flipy);
                //q = flipx * q * Quat.Conjugate(flipx);
                //q = flipz * q * Quat.Conjugate(flipz);
                //q = q9 * q * Quat.Conjugate(q9);


                //Console.Write(qq);
                //throw new Exception("boop");
                //(q.Z, q.Y) = (q.Y, q.Z);
                rotlist.Add(q9);
            }

            var (minX, maxX) = (poslist.Select(_ => _.X).Min(), poslist.Select(_ => _.X).Max());
            var cX = (maxX + minX) / 2;
            //minX + (maxX - minX)/2 == (maxX + minX)/2;
            var (minY, maxY) = (poslist.Select(_ => _.Y).Min(), poslist.Select(_ => _.Y).Max());
            var cY = (maxY + minY) / 2;

            var (minZ, maxZ) = (poslist.Select(_ => _.Z).Min(), poslist.Select(_ => _.Z).Max());
            var cZ = (maxZ + minZ) / 2;

            var (minW, maxW) = (poslist.Select(_ => _.W).Min(), poslist.Select(_ => _.W).Max());
            var cW = (maxW + minW) / 2;

            for (var i = 0; i < poslist.Count; i++)
            {
                var pos = poslist[i];
                pos.X -= cX;
                pos.Y -= cY;
                pos.Z -= cZ;
                //pos.W -= cW;
                poslist[i] = pos;
            }


            for (var i = 0; i < json.props.Count; i++)
            {
                var line = json.props[i];
                var current = RedJsonSerializer.Deserialize<worldNodeData>(tr);

                var b = new FileInfo(line.template_path).Extension == ".ent";

                if (Parent.Parent is not null &&
                    Parent.Parent.Data is not null &&
                    Parent.Parent.Data is worldStreamingSector wss)
                {
                    var currentnode = (CHandle<worldNode>)wss.Nodes[current.NodeIndex].DeepCopy();
                    var ttt = new worldEntityNode();
                    var tttp = new CHandle<worldNode>(ttt);


                    if (currentnode is not null &&
                        currentnode.GetValue() is not null)
                    {
                        //copy an ent node
                        if (b)
                        {

                            ttt.EntityTemplate.DepotPath = line.template_path;

                            /*var ent = currentnode.GetValue().GetProperty("EntityTemplate");
                            if (ent is CResourceAsyncReference<entEntityTemplate> e)
                            {
                                e.DepotPath = line.template_path;
                            }*/
                        }
                        //copy a mesh node
                        else
                        {
                            var mesh = currentnode.GetValue().GetProperty("Mesh");
                            if (mesh is CResourceAsyncReference<CMesh> m)
                            {
                                m.DepotPath = line.template_path;
                            }
                        }

                    }
                    var index = wss.Nodes.Count;
                    ((IRedArray)wss.Nodes).Insert(index, (IRedType)tttp);


                    var posandrot = poslist[i]; //RedJsonSerializer.Deserialize<Vec7S>(PutQuotes(line.pos));
                    var scala = line.scale == "nil" ? null : RedJsonSerializer.Deserialize<Vec3S>(PutQuotes(line.scale));

                    current.Position.X += posandrot.X;
                    current.Position.Y += posandrot.Y;
                    current.Position.Z += posandrot.Z;
                    current.Position.W *= posandrot.W;
                    if (scala is not null)
                    {
                        current.Scale.X = float.Parse(scala.x) / 100;
                        current.Scale.Y = float.Parse(scala.y) / 100;
                        current.Scale.Z = float.Parse(scala.z) / 100;
                    }
                    current.Orientation = rotlist[i];
                    //current.Orientation = Quat.Identity;// rotlist[i];

                    current.Pivot.X = current.Position.X;
                    current.Pivot.Y = current.Position.Y;
                    current.Pivot.Z = current.Position.Z;

                    current.MaxStreamingDistance = 5000;

                    current.NodeIndex = (CUInt16)index;


                    if (Parent.Data is DataBuffer db && db.Buffer.Data is IRedType irt)
                    {
                        if (irt is IRedArray ira && ira.InnerType.IsAssignableTo(current.GetType()))
                        {
                            var indexx = Parent.GetIndexOf(this) + 1;
                            if (indexx == -1 || indexx > ira.Count)
                            {
                                indexx = ira.Count;
                            }
                            ira.Insert(indexx, (IRedType)current);
                        }
                    }


                }
            }
        }

    }

    public class Root
    {
        public Root0 r0;
        public Root1 r1;
    }

    public class Rot
    {
        public float yaw { get; set; }
        public float roll { get; set; }
        public float pitch { get; set; }
    }

    public class Pos
    {
        public float y { get; set; }
        public float x { get; set; }
        public float z { get; set; }
        public float w { get; set; }
    }

    public class Child
    {
        public bool headerOpen { get; set; }
        public bool autoLoad { get; set; }
        public Rot rot { get; set; }
        public string path { get; set; }
        public Pos pos { get; set; }
        public string type { get; set; }
        public int loadRange { get; set; }
        public string name { get; set; }
        public string app { get; set; }
        public List<Child> childs { get; set; }
    }

    public class Root1 : Root
    {
        public List<Child> childs { get; set; }
        public Pos pos { get; set; }
        public int loadRange { get; set; }
        public bool headerOpen { get; set; }
        public string type { get; set; }
        public Rot rot { get; set; }
        public string name { get; set; }
        public bool autoLoad { get; set; }
    }


    public class Vec3S
    {
        public string x { get; set; }
        public string y { get; set; }
        public string z { get; set; }
    }
    public class Vec7S
    {
        public string x { get; set; }
        public string y { get; set; }
        public string z { get; set; }
        public string w { get; set; }
        public string roll { get; set; }
        public string pitch { get; set; }
        public string yaw { get; set; }
    }
    public class Vec7
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
        public float w { get; set; }
        public float roll { get; set; }
        public float pitch { get; set; }
        public float yaw { get; set; }
    }
    public class Prop
    {
        public string scale { get; set; }
        public string tag { get; set; }
        public string template_path { get; set; }
        public string entity_id { get; set; }
        public string pos { get; set; }
        public int uid { get; set; }
        public string app { get; set; }
        public string name { get; set; }
        public string trigger { get; set; }
    }

    public class Root0 : Root
    {
        public bool customIncluded { get; set; }
        public List<Prop> props { get; set; }
        public List<object> lights { get; set; }
        public string name { get; set; }
        public string file_name { get; set; }
    }


}
