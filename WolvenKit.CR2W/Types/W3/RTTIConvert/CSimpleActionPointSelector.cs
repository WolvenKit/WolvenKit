using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSimpleActionPointSelector : CActionPointSelector
	{
		[Ordinal(1)] [RED("categories", 2,0)] 		public CArray<CName> Categories { get; set;}

		[Ordinal(2)] [RED("apTags")] 		public TagList ApTags { get; set;}

		[Ordinal(3)] [RED("areaTags")] 		public TagList AreaTags { get; set;}

		[Ordinal(4)] [RED("apAreaTag")] 		public CName ApAreaTag { get; set;}

		[Ordinal(5)] [RED("keepActionPointOnceSelected")] 		public CBool KeepActionPointOnceSelected { get; set;}

		[Ordinal(6)] [RED("useNearestMatchingAP")] 		public CBool UseNearestMatchingAP { get; set;}

		public CSimpleActionPointSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSimpleActionPointSelector(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}