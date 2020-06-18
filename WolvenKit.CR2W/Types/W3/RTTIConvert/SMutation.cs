using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SMutation : CVariable
	{
		[RED("type")] 		public CEnum<EPlayerMutationType> Type { get; set;}

		[RED("colors", 2,0)] 		public CArray<CEnum<ESkillColor>> Colors { get; set;}

		[RED("progress")] 		public SMutationProgress Progress { get; set;}

		[RED("requiredMutations", 2,0)] 		public CArray<CEnum<EPlayerMutationType>> RequiredMutations { get; set;}

		[RED("localizationNameKey")] 		public CName LocalizationNameKey { get; set;}

		[RED("localizationDescriptionKey")] 		public CName LocalizationDescriptionKey { get; set;}

		[RED("iconPath")] 		public CName IconPath { get; set;}

		[RED("soundbank")] 		public CString Soundbank { get; set;}

		public SMutation(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SMutation(cr2w);

	}
}