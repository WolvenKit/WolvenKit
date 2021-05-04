using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4TestMenu : CR4MenuBase
	{
		[Ordinal(1)] [RED("entityTemplateIndex")] 		public CInt32 EntityTemplateIndex { get; set;}

		[Ordinal(2)] [RED("appearanceIndex")] 		public CInt32 AppearanceIndex { get; set;}

		[Ordinal(3)] [RED("environmentDefinitionIndex")] 		public CInt32 EnvironmentDefinitionIndex { get; set;}

		[Ordinal(4)] [RED("entityTemplates", 2,0)] 		public CArray<CString> EntityTemplates { get; set;}

		[Ordinal(5)] [RED("appearances", 2,0)] 		public CArray<CName> Appearances { get; set;}

		[Ordinal(6)] [RED("environmentDefinitions", 2,0)] 		public CArray<CString> EnvironmentDefinitions { get; set;}

		[Ordinal(7)] [RED("sunRotation")] 		public EulerAngles SunRotation { get; set;}

		public CR4TestMenu(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}