using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMutation : CVariable
	{
		[Ordinal(0)] [RED("("type")] 		public CEnum<EPlayerMutationType> Type { get; set;}

		[Ordinal(0)] [RED("("colors", 2,0)] 		public CArray<CEnum<ESkillColor>> Colors { get; set;}

		[Ordinal(0)] [RED("("progress")] 		public SMutationProgress Progress { get; set;}

		[Ordinal(0)] [RED("("requiredMutations", 2,0)] 		public CArray<CEnum<EPlayerMutationType>> RequiredMutations { get; set;}

		[Ordinal(0)] [RED("("localizationNameKey")] 		public CName LocalizationNameKey { get; set;}

		[Ordinal(0)] [RED("("localizationDescriptionKey")] 		public CName LocalizationDescriptionKey { get; set;}

		[Ordinal(0)] [RED("("iconPath")] 		public CName IconPath { get; set;}

		[Ordinal(0)] [RED("("soundbank")] 		public CString Soundbank { get; set;}

		public SMutation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMutation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}