using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SWorkSmartAIEntryGeneratorNodeParam : CVariable
	{
		[Ordinal(1)] [RED("apTag")] 		public TagList ApTag { get; set;}

		[Ordinal(2)] [RED("areaTags")] 		public TagList AreaTags { get; set;}

		[Ordinal(3)] [RED("apAreaTag")] 		public CName ApAreaTag { get; set;}

		[Ordinal(4)] [RED("keepActionPointOnceSelected")] 		public CBool KeepActionPointOnceSelected { get; set;}

		[Ordinal(5)] [RED("actionPointMoveType")] 		public CEnum<EMoveType> ActionPointMoveType { get; set;}

		public SWorkSmartAIEntryGeneratorNodeParam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SWorkSmartAIEntryGeneratorNodeParam(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}