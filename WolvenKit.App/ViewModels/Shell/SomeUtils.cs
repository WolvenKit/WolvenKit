using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using DynamicData;
using Splat;
using WolvenKit.Models;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;
using WolvenKit.Common;
using static WolvenKit.RED4.Types.Enums;
using WolvenKit.Functionality.Services;

using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;
using Quat = System.Numerics.Quaternion;
using Mat4 = System.Numerics.Matrix4x4;

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

        private (List<Vec4>, List<Quat>, List<string>) GetPosRotApp(List<Prop> props, int i = 0)
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
                    Z = float.Parse(posandrot.z) + (i * 10),
                    W = float.Parse(posandrot.w)
                };
                poslist.Add(v);

                var euler = new Vec3()
                {
                    X = (float)(Math.PI / 180) * float.Parse(posandrot.yaw),
                    Y = (float)(Math.PI / 180) * float.Parse(posandrot.pitch),
                    Z = (float)(Math.PI / 180) * float.Parse(posandrot.roll)
                };

                var q = FixRotation(euler, i);

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
                /*
                                var q = Quat.CreateFromYawPitchRoll(
                                    (float)(Math.PI / 180) * rot.yaw,
                                    (float)(Math.PI / 180) * rot.pitch,
                                    (float)(Math.PI / 180) * rot.roll);
                */
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


        public static Quat FixRotation(Vec3 euler, int i = 0)
        {
            var q = Quat.CreateFromRotationMatrix(
                    Mat4.Identity
                    * Mat4.CreateFromAxisAngle(Vec3.UnitY, euler.Z)
                    * Mat4.CreateFromAxisAngle(Vec3.UnitX, euler.Y)
                    * Mat4.CreateFromAxisAngle(Vec3.UnitZ, euler.X)
                    );
            //var mq = Mat4.CreateFromQuaternion(q);
            //var q9 = Quat.CreateFromRotationMatrix(mq);

            return q;
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

        private void AddToData(string tr, string path, Vec4 pos, Quat rot, string app, Vec3 scale = default, string ff = "", bool isdoor = false)
        {
            if (Parent.Parent is not null &&
                Parent.Parent.Data is not null &&
                Parent.Parent.Data is worldStreamingSector wss)
            {
                //loads the mesh when found and scaled
                if (scale == Vec3.One)
                {
                    AddEntity(tr, path, pos, wss, rot, app, scale, isdoor, visible: true);
                }
                else if (ff != "")
                {
                    AddEntity(tr, path, pos, wss, rot, app, scale, isdoor, visible: false);
                    AddMesh(tr, ff, pos, wss, rot, app, scale);
                }
            }
        }
        private void AddEntity(string tr, string path, Vec4 pos, worldStreamingSector wss, Quat rot, string app, Vec3 scale = default, bool isdoor = false, bool visible = true)
        {
            var current = RedJsonSerializer.Deserialize<worldNodeData>(tr);

            var wen = new worldEntityNode();
            var wenh = new CHandle<worldNode>(wen);
            var index = wss.Nodes.Count;

            //loading ents just for their colliders
            //gotta figure out colliders
            wen.IsVisibleInGame = visible;
            wen.EntityTemplate.DepotPath = path;
            wen.AppearanceName = app;

            if (isdoor)
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
            SetCoords(current, index, pos, rot, scale);
        }

        private void AddMesh(string tr, string path, Vec4 pos, worldStreamingSector wss, Quat rot, string app, Vec3 scale = default)
        {
            var current = RedJsonSerializer.Deserialize<worldNodeData>(tr);

            var cmesh = new worldStaticMeshNode();
            var wenh = new CHandle<worldNode>(cmesh);
            var index = wss.Nodes.Count;

            cmesh.OccluderType = visWorldOccluderType.None;
            cmesh.Mesh.DepotPath = path;
            cmesh.MeshAppearance = app;

            ((IRedArray)wss.Nodes).Insert(index, (IRedType)wenh);
            SetCoords(current, index, pos, rot, scale);
        }

        private void SetCoords(worldNodeData current, int index, Vec4 pos, Quat rot, Vec3 scale = default)
        {
            current.Position.X += pos.X;
            current.Position.Y += pos.Y;
            current.Position.Z += pos.Z;
            current.Position.W *= pos.W;

            current.Orientation = rot;

            //doesn't do anything in ents ?!?
            current.Scale.X = scale.X;
            current.Scale.Y = scale.Y;
            current.Scale.Z = scale.Z;

            current.Pivot.X = current.Position.X;
            current.Pivot.Y = current.Position.Y;
            current.Pivot.Z = current.Position.Z;

            //definitely does not go to 5000
            current.MaxStreamingDistance = 5000;

            //seem to be doing something to the max distance, kinda
            current.UkFloat1 = 5000;

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

        private static Vec4 GetCenter(Root1 r)
        {
            return new Vec4(r.pos.x, r.pos.y, r.pos.z, r.pos.w);
        }

        private void Add00(List<Prop> props, string tr)
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

                var entList = archiveEntList.Concat(modEntList).ToList();
                var meshList = archiveMeshList.Concat(modMeshList).ToList();

                // this searches for the name of the file as .mesh
                // and changes the path if a new path is found

                var (poslist, rotlist, applist) = GetPosRotApp(props);
                var center = GetCenter(poslist);


                poslist = UpdateCoords(poslist, center);

                for (var i = 0; i < props.Count; i++)
                {
                    var line = props[i];
                    var current = RedJsonSerializer.Deserialize<worldNodeData>(tr);

                    var scala = line.scale == "nil" ? null
                        : RedJsonSerializer.Deserialize<Vec3S>(PutQuotes(line.scale));
                    var scale = scala is null ? Vec3.One : new Vec3(
                        float.Parse(scala.x) / 100,
                        float.Parse(scala.y) / 100,
                        float.Parse(scala.z) / 100
                        );

                    var ff = "";

                    if (scale != Vec3.One)
                    {
                        var path = line.template_path;
                        var sp = Path.GetFileName(path);
                        var spm = Path.ChangeExtension(sp, ".mesh");

                        /*
                                                var foundents = entList.Where(x => x.FileName.Contains(sp)).Select(_ => _).ToList();
                                                if (foundents.Any())
                                                {
                                                    var foundent = foundents.Last();
                                                    using var db = new RedDBContext();

                                                    var file = new RedFileViewModel(foundent);
                                                    var hash = file.GetGameFile().Key;
                        */
                        //}

                        var foundmesh = meshList.Where(x => x.FileName.Contains(spm)).Select(_ => _).ToList();
                        ff = foundmesh.Count == 0 ? "" : foundmesh.Last().FileName;

                    }
                    var door = line.isdoor is bool b ? b : false;

                    AddToData(tr, line.template_path, poslist[i], rotlist[i], applist[i], scale, ff, door);
                }
            }
            catch { }
        }

        private void Add00(Root1 json, string tr)
        {
            var props = GetLines(json);
            var (poslist, rotlist, applist) = GetPosRotApp(props);
            var center = GetCenter(json);

            poslist = UpdateCoords(poslist, center);

            for (var i = 0; i < props.Count; i++)
            {
                var line = props[i];
                AddToData(tr, line.path, poslist[i], rotlist[i], applist[i]);
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
        public bool isdoor { get; set; }
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
