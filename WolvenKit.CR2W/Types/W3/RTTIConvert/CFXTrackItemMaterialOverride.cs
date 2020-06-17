using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXTrackItemMaterialOverride : CFXTrackItem
	{
		[RED("material")] 		public CHandle<IMaterial> Material { get; set;}

		[RED("exclusionTag")] 		public CName ExclusionTag { get; set;}

		[RED("drawOriginal")] 		public CBool DrawOriginal { get; set;}

		[RED("includeList", 2,0)] 		public CArray<CName> IncludeList { get; set;}

		[RED("excludeList", 2,0)] 		public CArray<CName> ExcludeList { get; set;}

		[RED("forceMeshAlternatives")] 		public CBool ForceMeshAlternatives { get; set;}

		public CFXTrackItemMaterialOverride(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CFXTrackItemMaterialOverride(cr2w);

	}
}