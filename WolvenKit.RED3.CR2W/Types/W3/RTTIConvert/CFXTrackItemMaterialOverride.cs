using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXTrackItemMaterialOverride : CFXTrackItem
	{
		[Ordinal(1)] [RED("material")] 		public CHandle<IMaterial> Material { get; set;}

		[Ordinal(2)] [RED("exclusionTag")] 		public CName ExclusionTag { get; set;}

		[Ordinal(3)] [RED("drawOriginal")] 		public CBool DrawOriginal { get; set;}

		[Ordinal(4)] [RED("includeList", 2,0)] 		public CArray<CName> IncludeList { get; set;}

		[Ordinal(5)] [RED("excludeList", 2,0)] 		public CArray<CName> ExcludeList { get; set;}

		[Ordinal(6)] [RED("forceMeshAlternatives")] 		public CBool ForceMeshAlternatives { get; set;}

		public CFXTrackItemMaterialOverride(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}