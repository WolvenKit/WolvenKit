using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Model
{
    public static class BulkEditor
    {

        private async static Task<int> RunBulkEdit(
            string dir,
            string ext,
            string chunk,
            string var,
            string type,
            string val)
        {

            List<string> files = MainController.Get().ActiveMod.Files;
            if (!Directory.Exists(dir))
            {
                return 0;
            }
            else
            {
                string searchpattern = "*";
                if (ext != null)
                {
                    ext.TrimStart('.');
                    searchpattern = $"*.{ext}";
                }
                files = Directory.GetFiles(dir, searchpattern).ToList();
            }

            foreach (var path in files)
            {
                var fullpath = Path.Combine(MainController.Get().ActiveMod.FileDirectory, path);
                if (ext != null && !Path.GetExtension(fullpath).Contains(ext))
                    continue;


                CR2WFile cr2w;
                using (var fs = new FileStream(fullpath, FileMode.Open, FileAccess.Read))
                using (var reader = new BinaryReader(fs))
                {
                    cr2w = new CR2WFile(reader);
                    fs.Close();
                }
                var task = Task.Run(() => EditVariablesInFile(cr2w, chunk, var, type, val));
                await task.ContinueWith(antecedent =>
                {
                    using (var fs = new FileStream(fullpath, FileMode.Open, FileAccess.ReadWrite))
                    using (var writer = new BinaryWriter(fs))
                    {
                        cr2w.Write(writer);
                        //AddOutput($"Succesfully edited {path}.", Logtype.Success);
                    }
                });
            }

            return 0;
        }

        private static async Task EditVariablesInFile(CR2WFile file,
            string chunk,
            string var,
            string type,
            string val
            )
        {
            if (file == null)
                return;
            if (chunk != null && !file.chunks.Any(_ => chunk.Contains(_.Type)))
                return;

            // get chunks that match chunkname
            List<CR2WExportWrapper> chunks = chunk != null ? file.chunks.Where(_ => chunk.Contains(_.Type)).ToList() : file.chunks;

            foreach (CR2WExportWrapper c in chunks)
            {
                EditVariables(c.data);
            }

            // local 
            void EditVariables(CVariable vec)
            {
                if (vec == null)
                    return;
                FieldInfo[] fields = vec.GetType().GetFields();

                foreach (var f in fields)
                {
                    var v = f.GetValue(vec);
                    if (v is IList && v.GetType().IsGenericType)
                    {
                        foreach (var listitem in (v as IList))
                        {
                            if (listitem is CVariable)
                                EditVariables(listitem as CVariable);
                        }
                    }
                    if (v is CVariable)
                    {
                        if (v == null)
                            continue;
                        // is a match
                        if (((CVariable)v).Name == var)
                        {
                            // is not of type
                            if (type != null && ((CVariable)v).Type != type)
                            {
                                continue;
                            }
                            // edit value
                            ((CVariable)v).SetValue(val);
                        }
                        // check if variable has more children
                        EditVariables(((CVariable)v));
                    }
                }
            }
        }
    }
}
