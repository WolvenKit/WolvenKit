using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Text.Json;
using WolvenKit.Core.Extensions;
using WolvenKit.ProjectManagement.Project;
using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;

namespace WolvenKit.App.Models
{
    public class Prop
    {
        public string scale { get; set; }
        public string? tag { get; set; }
        public string template_path { get; set; }
        public string? entity_id { get; set; }
        public string pos { get; set; }
        public int uid { get; set; }
        public string app { get; set; }
        public string name { get; set; }
        public string? trigger { get; set; }
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

        public static Prop FromChild(Child C)
        {
            return new()
            {
                name = C.name,
                app = C.app.NotNull(),
                template_path = C.path.NotNull(),
                scale = "nil",
                pos = PosRotToString(C.pos, C.rot)
            };
        }


        public static Prop FromJsonObjectSpawner(JsonObjectSpawner C)
        {
            ArgumentNullException.ThrowIfNull(C.pos);
            ArgumentNullException.ThrowIfNull(C.rot);

            return new()
            {
                name = Path.GetFileNameWithoutExtension(C.path).NotNull(),
                app = C.app.NotNull(),
                template_path = C.path.NotNull(),
                scale = "nil",
                pos = PosRotToString(C.pos, C.rot)
            };
        }

        public static Prop FromObjectList(List<object> C, Cp77Project project)
        {
            var fileslist = project.Files.ToList();

            if (C[1] is not JsonElement jsonElement)
            {
                throw new ArgumentException("invalid argument type", nameof(C));
            }

            var meshname = jsonElement.GetString().NotNull().ToLower();
            var foundnames = fileslist
                .Where(x => x.Contains(meshname) && x.Contains(".mesh"))
                .Select(x => x).ToList();

            if (foundnames.Count > 0)
            {
                var foundname =
                    string.Join("\\", foundnames.First().Split("\\").Skip(1).ToArray());


                var scaleX = ((JsonElement)C[7])[0].GetDouble().ToString();
                var scaleY = ((JsonElement)C[7])[1].GetDouble().ToString();
                var scaleZ = ((JsonElement)C[7])[2].GetDouble().ToString();

                return new Prop()
                {
                    name = meshname,
                    app = "default",
                    template_path = foundname,
                    scale = "{" + $"x = {scaleX}, y = {scaleY}, z = {scaleZ}" + "}",
                    pos = PosRotToString(
                        new Pos()
                        {
                            x = (float)((JsonElement)C[5])[0].GetDouble(),
                            y = (float)((JsonElement)C[5])[1].GetDouble(),
                            z = (float)((JsonElement)C[5])[2].GetDouble(),
                            w = 1
                        }
                        , new Rot()
                        {
                            roll = (float)((JsonElement)C[6])[0].GetDouble(),
                            pitch = (float)((JsonElement)C[6])[2].GetDouble(),
                            yaw = (float)((JsonElement)C[6])[1].GetDouble(),
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

}
