using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCSharedDataDefinition : CVariable
	{
		[Ordinal(0)]  [RED("defaultChoices")] public CArray<CString> DefaultChoices { get; set; }
		[Ordinal(1)]  [RED("visualizer")] public CHandle<gameuiIChoiceVisualizer> Visualizer { get; set; }

		public gameinteractionsCSharedDataDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
