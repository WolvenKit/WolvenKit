using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCSharedDataDefinition : CVariable
	{
		[Ordinal(0)] [RED("defaultChoices")] public CArray<CString> DefaultChoices { get; set; }
		[Ordinal(1)] [RED("visualizer")] public CHandle<gameuiIChoiceVisualizer> Visualizer { get; set; }

		public gameinteractionsCSharedDataDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
