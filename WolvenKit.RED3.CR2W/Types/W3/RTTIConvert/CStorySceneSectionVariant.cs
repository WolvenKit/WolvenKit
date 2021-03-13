using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneSectionVariant : CVariable
	{
		[Ordinal(1)] [RED("id")] 		public CUInt32 Id { get; set;}

		[Ordinal(2)] [RED("localeId")] 		public CUInt32 LocaleId { get; set;}

		[Ordinal(3)] [RED("events", 2,0)] 		public CArray<CGUID> Events { get; set;}

		[Ordinal(4)] [RED("elementInfo", 2,0)] 		public CArray<CStorySceneSectionVariantElementInfo> ElementInfo { get; set;}

		public CStorySceneSectionVariant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneSectionVariant(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}