using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Text.Json.Serialization;
using DynamicData;
using MoreLinq;
using Splat;
using WolvenKit.Common;
using WolvenKit.Functionality.Services;
using WolvenKit.Models;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;

using Mat4 = System.Numerics.Matrix4x4;
using Quat = System.Numerics.Quaternion;
using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;

namespace WolvenKit.ViewModels.Shell
{
    public partial class ChunkViewModel
    {
        private static Vec4 GetCenter(List<Vec4> poslist)
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

        private static Vec4 GetCenter(Root2 json)
        {
            var poslist =
                json.Select(j =>
                new Vec3()
                {
                    X = float.Parse(
                        ((System.Text.Json.JsonElement)j[5])[0].GetRawText()
                        ),
                    Y = float.Parse(
                        ((System.Text.Json.JsonElement)j[5])[1].GetRawText()
                        ),
                    Z = float.Parse(
                        ((System.Text.Json.JsonElement)j[5])[2].GetRawText()
                        )
                }
                ).ToList();

            //minX + (maxX - minX)/2 == (maxX + minX)/2;
            var (minX, maxX) = (poslist.Select(_ => _.X).Min(), poslist.Select(_ => _.X).Max());
            var cX = (maxX + minX) / 2;

            var (minY, maxY) = (poslist.Select(_ => _.Y).Min(), poslist.Select(_ => _.Y).Max());
            var cY = (maxY + minY) / 2;

            var (minZ, maxZ) = (poslist.Select(_ => _.Z).Min(), poslist.Select(_ => _.Z).Max());
            var cZ = (maxZ + minZ) / 2;

            return new Vec4(cX, cY, cZ, 1);
        }

        private static Vec4 GetPos(Prop line)
        {
            var posandrot = RedJsonSerializer.Deserialize<Vec7S>(PutQuotes(line.pos));
            return new Vec4()
            {
                X = float.Parse(posandrot.x),
                Y = float.Parse(posandrot.y),
                Z = float.Parse(posandrot.z),
                W = float.Parse(posandrot.w)
            };
        }

        private static List<Vec4> GetPos(List<Prop> props)
        {
            var poslist = new List<Vec4>();
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
            }
            return poslist;
        }

        private (Vec4, Quat) GetPosRot(Prop line)
        {
            var posandrot = RedJsonSerializer.Deserialize<Vec7S>(PutQuotes(line.pos));
            var v =
                posandrot == null
                ? new Vec4()
                : new Vec4()
                {
                    X = float.Parse(posandrot.x),
                    Y = float.Parse(posandrot.y),
                    Z = float.Parse(posandrot.z),
                    W = float.Parse(posandrot.w)
                };

            var euler =
                posandrot == null
                ? new Vec3()
                : new Vec3()
                {
                    X = (float)(Math.PI / 180) * float.Parse(posandrot.yaw),
                    Y = (float)(Math.PI / 180) * float.Parse(posandrot.pitch),
                    Z = (float)(Math.PI / 180) * float.Parse(posandrot.roll)
                };
            var q = line.isunreal ? FixRotation2(euler) :
                FixRotation(euler);

            return (v, q);
        }

        private (List<Vec4>, List<Quat>) GetPosRot(List<Prop> props)
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

                var euler = new Vec3()
                {
                    X = (float)(Math.PI / 180) * float.Parse(posandrot.yaw),
                    Y = (float)(Math.PI / 180) * float.Parse(posandrot.pitch),
                    Z = (float)(Math.PI / 180) * float.Parse(posandrot.roll)
                };
                var q = FixRotation(euler);

                rotlist.Add(q);
            }
            return (poslist, rotlist);
        }

        private (List<Vec4>, List<Quat>, List<string>) GetPosRotApp(List<Prop> props)
        {
            var poslist = new List<Vec4>();
            var rotlist = new List<Quat>();
            var applist = new List<string>();

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

                var euler = new Vec3()
                {
                    X = (float)(Math.PI / 180) * float.Parse(posandrot.yaw),
                    Y = (float)(Math.PI / 180) * float.Parse(posandrot.pitch),
                    Z = (float)(Math.PI / 180) * float.Parse(posandrot.roll)
                };

                var q = FixRotation(euler);

                // (q.Y, q.Z) = (-q.Z, -q.Y);
                rotlist.Add(q);

                applist.Add(line.app);
            }
            return (poslist, rotlist, applist);
        }

        private (List<Vec4>, List<Quat>, List<string>) GetPosRotApp(List<Child> props)
        {
            var poslist = new List<Vec4>();
            var rotlist = new List<Quat>();
            var applist = new List<string>();

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

                var euler = new Vec3()
                {
                    X = (float)(Math.PI / 180) * rot.yaw,
                    Y = (float)(Math.PI / 180) * rot.pitch,
                    Z = (float)(Math.PI / 180) * rot.roll
                };

                var q = FixRotation(euler);

                rotlist.Add(q);

                if (line.app != null)
                {
                    string app = line.app == "" ? "default" : line.app;
                    applist.Add(app);
                }
                else
                {
                    applist.Add("default");
                }
            }
            return (poslist, rotlist, applist);
        }

        private static string PutQuotes(string w)
        {
            w = w.Replace("{", "{\"");
            w = w.Replace("}", "\"}");
            w = w.Replace(", ", "\",\"");
            w = w.Replace(" = ", "\":\"");
            return w;
        }

        public void Refresh()
        {
            var currentfile = new FileModel(Tab.File.FilePath,
                Locator.Current.GetService<AppViewModel>().ActiveProject);
            Tab.File.TabItemViewModels
                .RemoveMany(Tab.File.TabItemViewModels.AsEnumerable());

            var ad = Locator.Current.GetService<AppViewModel>().ActiveDocument;
            ad.OpenFileAsync(currentfile.FullName);
        }


        public static Quat FixRotation(Vec3 euler) =>
            Quat.CreateFromRotationMatrix(
                Mat4.Identity
                * Mat4.CreateFromAxisAngle(Vec3.UnitY, euler.Z)
                * Mat4.CreateFromAxisAngle(Vec3.UnitX, euler.Y)
                * Mat4.CreateFromAxisAngle(Vec3.UnitZ, euler.X)
                );

        public static Quat FixRotation2(Vec3 euler) =>
            Quat.CreateFromRotationMatrix(
                Mat4.Identity
                * Mat4.CreateFromAxisAngle(Vec3.UnitZ, (float)Math.PI)
                * Mat4.CreateFromAxisAngle(-Vec3.UnitX, euler.Y)
                * Mat4.CreateFromAxisAngle(Vec3.UnitY, euler.Z)
                * Mat4.CreateFromAxisAngle(-Vec3.UnitZ, euler.X)
                );


        private static Vec4 UpdateCoords(Vec4 pos, Vec4 center)
        {
            pos.X -= center.X;
            pos.Y -= center.Y;
            pos.Z -= center.Z;
            //pos.W -= center.W;

            return pos;
        }

        private static List<Vec4> UpdateCoords(List<Vec4> poslist, Vec4 center)
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

        private void AddToData(string tr, Prop line, string ff = "", bool updatecoords = true)
        {
            if (Parent.Parent is not null &&
                Parent.Parent.Data is not null &&
                Parent.Parent.Data is worldStreamingSector)
            {
                //loads the mesh when found and scaled
                if (GetScale(line) == Vec3.One)
                {
                    AddEntity(tr, line, updatecoords);
                }
                else if (ff != "")
                {
                    AddMesh(tr, line, updatecoords);
                }
            }
        }

        private void AddEntity(string tr, Prop line, bool updatecoords = true, bool visible = true)
        {
            var wss = (worldStreamingSector)Parent.Parent.Data;
            var current = RedJsonSerializer.Deserialize<worldNodeData>(tr);

            var wen = new worldEntityNode();
            var wenh = new CHandle<worldNode>(wen);
            var index = wss.Nodes.Count;

            //loading ents just for their colliders
            //gotta figure out colliders
            wen.IsVisibleInGame = visible;
            wen.EntityTemplate.DepotPath = line.template_path;
            wen.AppearanceName = line.app == "" ? "default" : line.app;
            wen.DebugName = line.template_path + "_" + index.ToString();


            if (line.isdoor is bool b && b)
            {
                var eeid = new entEntityInstanceData();
                var eeidh = new CHandle<entEntityInstanceData>(eeid);

                wen.InstanceData = eeidh;
                eeid.Buffer = new DataBuffer();

                var pk = new Package04();
                var dc = new DoorController();
                pk.Chunks = new List<RedBaseClass>();

                dc.PersistentState = new DoorControllerPS()
                {
                    IsInteractive = true
                };
                pk.Chunks.Add((RedBaseClass)dc);
                eeid.Buffer.Data = pk;
            }

            ((IRedArray)wss.Nodes).Insert(index, (IRedType)wenh);
            SetCoords(current, index, line, updatecoords);
        }

        private void AddMesh(string tr, Prop line, bool updatecoords = true, Vec4 pos = default, Quat rot = default)
        {
            var wss = (worldStreamingSector)Parent.Parent.Data;
            var current = RedJsonSerializer.Deserialize<worldNodeData>(tr);

            //var cmesh = new worldStaticMeshNode();
            var cmesh = new worldGenericProxyMeshNode();

            var wenh = new CHandle<worldNode>(cmesh);
            var index = wss.Nodes.Count;

            cmesh.DebugName = Path.GetFileNameWithoutExtension(line.template_path) + "_" + index.ToString();
            cmesh.ForceAutoHideDistance = 20000;
            cmesh.NearAutoHideDistance = 0;
            //not sure what these do
            //cmesh.RemoveFromRainMap = true;
            //cmesh.OccluderType = visWorldOccluderType.Exterior;

            //line.template_path;//
            //@"engine\meshes\editor\cube.mesh";
            //
            cmesh.Mesh.DepotPath = line.template_path;
            cmesh.MeshAppearance = line.app == "" ? "default" : line.app;

            ((IRedArray)wss.Nodes).Insert(index, (IRedType)wenh);

            SetCoords(current, index, line, updatecoords, pos, rot);

        }

        private void SetCoords(worldNodeData current, int index, Prop line, bool updatecoords = true, Vec4 pos = default, Quat rot = default)
        {
            if (pos == default || rot == default)
            {
                (pos, rot) = GetPosRot(line);
            }

            var scale = line.isunreal ? GetScale(line, (float)1) : GetScale(line);
            var f = line.isunreal ? (float)0.01 : 1;

            if (line.center != default && updatecoords)
            {
                if (line.isunreal)
                {
                    pos = UpdateCoords(pos, line.center);
                    current.Position.X += -pos.X * f;
                    current.Position.Y += pos.Y * f;
                    current.Position.Z += pos.Z * f;
                    current.Position.W *= pos.W * f;
                }
                else
                {
                    pos = UpdateCoords(pos, line.center);
                    current.Position.X += pos.X * f;
                    current.Position.Y += pos.Y * f;
                    current.Position.Z += pos.Z * f;
                    current.Position.W *= pos.W * f;
                }
            }
            else
            {
                current.Position = Vec4.Multiply(f, pos);
            }

            current.Orientation = rot;
            //doesn't do anything in ents ?!?
            current.Scale = scale;
            current.Pivot.X = current.Position.X;
            current.Pivot.Y = current.Position.Y;
            current.Pivot.Z = current.Position.Z;
            //definitely does not go to 5000
            current.MaxStreamingDistance = 20000;
            //seem to be doing something to the max distance, kinda
            current.UkFloat1 = 20000;
            current.Uk11 = 20000;
            current.NodeIndex = (CUInt16)index;
            AddCurrent(current);
        }

        private void AddCurrent(worldNodeData current)
        {
            if (Parent.Data is DataBuffer db00 &&
                db00.Buffer.Data is worldNodeDataBuffer db0)
            {
                if (!db0.Lookup.ContainsKey(current.NodeIndex))
                {
                    db0.Lookup[current.NodeIndex] = new();
                }
                db0.Lookup[current.NodeIndex].Add(current);
            }

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

        private List<Child> GetLines(Root1 json)
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

        private void GetLines(Child c, List<Child> props)
        {
            var v = new Child()
            {
                pos = c.pos,
                rot = c.rot,
                name = c.name,
                path = c.path,
                app = c.app
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

        private static Vec4 GetCenter(Root1 r) => new(r.pos.x, r.pos.y, r.pos.z, r.pos.w);

        private void Add00(List<Prop> props, string tr, bool updatecoords = true)
        {
            try
            {
                var am = Locator.Current.GetService<IArchiveManager>();
                var sm = Locator.Current.GetService<ISettingsManager>();
                am.LoadModsArchives(new DirectoryInfo(sm.GetRED4GameModDir()), null);
                var af = am.GetGroupedFiles();

                var tempbool = am.IsModBrowserActive;
                am.IsModBrowserActive = true;
                var tt2 = am.GetGroupedFiles();

                var archiveMeshList = af[".mesh"].GroupBy(x => x.Key).Select(x => x.First()).ToList();
                var modMeshList = tt2[".mesh"].GroupBy(x => x.Key).Select(x => x.First()).ToList();
                var archiveEntList = af[".ent"].GroupBy(x => x.Key).Select(x => x.First()).ToList();
                var modEntList = tt2[".ent"].GroupBy(x => x.Key).Select(x => x.First()).ToList();
                am.IsModBrowserActive = tempbool;

                //lists of all ents and mesh found in archives and mods
                var entList = archiveEntList.Concat(modEntList).ToList();
                var meshList = archiveMeshList.Concat(modMeshList).ToList();

                var center = updatecoords ? GetCenter(GetPos(props)) : new Vec4();

                foreach (var line in props)
                {
                    if (updatecoords)
                    { line.center = center; }
                    var current = RedJsonSerializer.Deserialize<worldNodeData>(tr);

                    var scale = GetScale(line);
                    var door = line.isdoor is bool b && b;

                    if (scale != Vec3.One)
                    {
                        var path = line.template_path;
                        var sp = Path.GetFileName(path);
                        var spm = Path.ChangeExtension(sp, ".mesh");

                        //find ent
                        var foundents = entList.Where(x => x.FileName.Contains(sp)).Select(_ => _).ToList();

                        if (foundents.Any() && foundents.Last() is FileEntry foundent)
                        {
                            using var stream = new MemoryStream();
                            foundent.Extract(stream);
                            using var reader = new BinaryReader(stream);
                            var cr2wFile = Locator.Current.GetService<Red4ParserService>().ReadRed4File(reader);

                            //open ent
                            if (cr2wFile is not null &&
                                cr2wFile.RootChunk is entEntityTemplate rc &&
                                rc.CompiledData.Data is RedPackage data)
                            {
                                var meshes = data.Chunks.Where(x => x is entMeshComponent)
                                             .Select(_ => (entMeshComponent)_).ToList();

                                for (var i1 = 0; i1 < meshes.Count; i1++)
                                {
                                    var mesh = meshes[i1];
                                    var (p, r) = GetPosRot(line);

                                    var t = mesh.LocalTransform.Position;
                                    var mp = new Vec4(t.X, t.Y, t.Z, 1);

                                    var np = p + mp;
                                    var nrq = r * mesh.LocalTransform.Orientation;

                                    var newline = new Prop()
                                    {
                                        name = line.name + "_" + i1,
                                        app = line.app == "" ? "default" : line.app,
                                        template_path = mesh.Mesh.DepotPath,
                                        scale = line.scale
                                    };

                                    AddMesh(tr, newline, updatecoords, np, nrq);
                                }
                            }
                            else
                            {
                                var foundmesh = meshList.Where(x => x.FileName.Contains(spm)).Select(_ => _.FileName).ToList();
                                if (foundmesh.Count > 0)
                                {
                                    line.template_path = foundmesh.Last();
                                    AddMesh(tr, line, updatecoords);
                                }
                            }
                        }
                        else
                        {
                            var foundmesh = meshList.Where(x => x.FileName.Contains(spm)).Select(_ => _.FileName).ToList();
                            if (foundmesh.Count > 0)
                            {
                                line.template_path = foundmesh.Last();
                                AddMesh(tr, line, updatecoords);
                            }
                            else
                            {
                                //those ents will not be scaled properly
                                //if they load anything at all
                                AddEntity(tr, line, updatecoords);
                            }
                        }
                    }
                    else
                    {
                        AddEntity(tr, line, updatecoords);
                    }
                }
            }
            catch { }
        }

        private void Add00(Root1 json, string tr, bool updatecoords = true)
        {
            var center = updatecoords ? GetCenter(json) : new Vec4();
            var props = GetLines(json);

            foreach (Prop line in props)
            {
                if (updatecoords)
                { line.center = center; }
                AddEntity(tr, line, updatecoords);
            }
        }

        private void Add00(Root2 json, string tr, bool updatecoords = true)
        {
            var center = updatecoords ? GetCenter(json) : new Vec4();

            foreach (Prop line in json)
            {
                if (updatecoords)
                { line.center = center; }
                line.isunreal = true;
                AddMesh(tr, line, updatecoords);
            }
        }

        private Vec3 GetScale(Prop line, float factor = (float)0.01)
        {
            var scala = line.scale == "nil" ? null
                : RedJsonSerializer.Deserialize<Vec3S>(PutQuotes(line.scale));
            return scala is null ? Vec3.One : new Vec3(
                float.Parse(scala.x) * factor,
                float.Parse(scala.y) * factor,
                float.Parse(scala.z) * factor
                );
        }

        public static void CreateFromYawPitchRoll(Quaternion r, out float yaw, out float pitch, out float roll)
        {
            yaw = MathF.Atan2(2.0f * (r.J * r.R + r.I * r.K), 1.0f - 2.0f * (r.I * r.I + r.J * r.J));
            pitch = MathF.Asin(2.0f * (r.I * r.R - r.J * r.K));
            roll = MathF.Atan2(2.0f * (r.I * r.J + r.K * r.R), 1.0f - 2.0f * (r.I * r.I + r.K * r.K));
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
        public bool isdoor { get; set; }
        public bool isunreal { get; set; }

        public Vec4 center { get; set; }

        public Prop()
        {
            name = "";
            app = "default";
            template_path = "";
            scale = "nil";
            pos = "";
        }

        public static string PosRotToString(Vec4 pos, Vec3 rot) =>
            "{" + $"x = {pos.X} , y = {pos.Y} , z = {pos.Z} , w = {pos.W} , roll = {rot.X} , pitch = {rot.Y} , yaw = {rot.Z} " + "}";
        private static string PosRotToString(Pos pos, Rot rot) =>
            "{" + $"x = {pos.x} , y = {pos.y} , z = {pos.z} , w = {pos.w} , roll = {rot.roll} , pitch = {rot.pitch} , yaw = {rot.yaw} " + "}";

        public static implicit operator Prop(Child C) =>
          new()
          {
              name = C.name,
              app = C.app,
              template_path = C.path,
              scale = "nil",
              pos = PosRotToString(C.pos, C.rot)
          };

        public static implicit operator Prop(List<object> C)
        {
            var pm = Locator.Current.GetService<IProjectManager>();

            var fileslist = pm.ActiveProject.Files.ToList();

            var meshname = ((System.Text.Json.JsonElement)C[1]).GetString().ToLower();
            var foundnames = fileslist
                .Where(x => x.Contains(meshname) && x.Contains(".mesh"))
                .Select(x => x).ToList();

            if (foundnames.Count > 0)
            {
                var foundname =
                    String.Join("\\", foundnames.First().Split("\\").Skip(1).ToArray());


                var scaleX = ((System.Text.Json.JsonElement)C[7])[0].GetDouble().ToString();
                var scaleY = ((System.Text.Json.JsonElement)C[7])[1].GetDouble().ToString();
                var scaleZ = ((System.Text.Json.JsonElement)C[7])[2].GetDouble().ToString();

                return new Prop()
                {
                    name = meshname,
                    app = "default",
                    template_path = foundname,
                    scale = "{" + $"x = {scaleX}, y = {scaleY}, z = {scaleZ}" + "}",
                    pos = PosRotToString(
                        new Pos()
                        {
                            x = (float)(((System.Text.Json.JsonElement)C[5])[0].GetDouble()),
                            y = (float)(((System.Text.Json.JsonElement)C[5])[1].GetDouble()),
                            z = (float)(((System.Text.Json.JsonElement)C[5])[2].GetDouble()),
                            w = (float)1
                        }
                        , new Rot()
                        {
                            roll = (float)(((System.Text.Json.JsonElement)C[6])[0].GetDouble()),
                            pitch = (float)(((System.Text.Json.JsonElement)C[6])[2].GetDouble()),
                            yaw = (float)(((System.Text.Json.JsonElement)C[6])[1].GetDouble()),
                        }
                    )
                };
            }
            else
            {
                return new Prop();
            }
        }
    }

    public class Root0 : Root
    {
        public bool customIncluded { get; set; }
        public List<Prop> props { get; set; }
        public List<object> lights { get; set; }
        public string name { get; set; }
        public string file_name { get; set; }
    }

    public class Root2 : List<List<object>>
    {

    }

}
