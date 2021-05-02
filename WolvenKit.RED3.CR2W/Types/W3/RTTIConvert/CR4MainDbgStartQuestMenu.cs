using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4MainDbgStartQuestMenu : CR4MenuBase
	{
		[Ordinal(1)] [RED("m_optionsNames", 2,0)] 		public CArray<CName> M_optionsNames { get; set;}

		[Ordinal(2)] [RED("m_gameResources", 2,0)] 		public CArray<CString> M_gameResources { get; set;}

		public CR4MainDbgStartQuestMenu(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4MainDbgStartQuestMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}