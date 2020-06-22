using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4TestMenu : CR4MenuBase
	{
		[RED("entityTemplateIndex")] 		public CInt32 EntityTemplateIndex { get; set;}

		[RED("appearanceIndex")] 		public CInt32 AppearanceIndex { get; set;}

		[RED("environmentDefinitionIndex")] 		public CInt32 EnvironmentDefinitionIndex { get; set;}

		[RED("entityTemplates", 2,0)] 		public CArray<CString> EntityTemplates { get; set;}

		[RED("appearances", 2,0)] 		public CArray<CName> Appearances { get; set;}

		[RED("environmentDefinitions", 2,0)] 		public CArray<CString> EnvironmentDefinitions { get; set;}

		[RED("sunRotation")] 		public EulerAngles SunRotation { get; set;}

		public CR4TestMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4TestMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}