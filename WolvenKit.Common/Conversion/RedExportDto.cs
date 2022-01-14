using System.Collections.Generic;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.Common.Conversion
{
    public class RedExportDto
    {
        public string Type { get; set; }

        //public int ChunkIndex { get; set; }
        public int ParentIndex { get; set; }
        public Dictionary<string, object> Properties { get; set; } = new();

        public bool ShouldSerializeProperties() => Properties is { Count: > 0 };

        public RedExportDto()
        {

        }

        public RedExportDto(ICR2WExport cr2WExport)
        {
            throw new TodoException();
            //Type = cr2WExport.REDType;

            ////ChunkIndex = cr2WExport.ChunkIndex;
            //ParentIndex = cr2WExport.ParentChunkIndex;
            //var cvarAsDict = cr2WExport.Data.ToObject();
            //if (cvarAsDict is Dictionary<string, object> dict)
            //{
            //    Properties = dict;
            //}
            //else
            //{
            //    throw new SerializationException();
            //}
        }

        public void CreateChunkInFile(CR2WFile cr2WFile, int idx) => throw new TodoException();//ICR2WExport parentChunk;//if (ParentIndex == -1)//{//    parentChunk = null;//}//else//{//    var foundChunk = cr2WFile.Chunks.FirstOrDefault(_ => _.ChunkIndex == ParentIndex);//    if (foundChunk is null)//    {//        throw new SerializationException("No parentchunk found");//    }//    else//    {//        parentChunk = foundChunk;//    }//}// create wrapped Cvariable//var cvar = CR2WTypeManager.Create(Type, Type, cr2WFile, parentChunk?.Data as CVariable);// add data//cvar.SetFromDictionary(Properties);//cr2WFile.CreateChunk(cvar, idx, parentChunk as CR2WExportWrapper);

    }
}
