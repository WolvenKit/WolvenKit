using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CLayer : CResource
	{
		[Ordinal(1)] [RED("entities", 32,0)] 		public CArray<CPtr<CEntity>> Entities { get; set;}

		[Ordinal(2)] [RED("sectorData")] 		public CHandle<CSectorData> SectorData { get; set;}

		[Ordinal(3)] [RED("nameCount")] 		public CUInt32 NameCount { get; set;}

		public CLayer(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CLayer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}