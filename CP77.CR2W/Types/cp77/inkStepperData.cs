using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkStepperData : CVariable
	{
		[Ordinal(0)]  [RED("data")] public wCHandle<IScriptable> Data { get; set; }
		[Ordinal(1)]  [RED("label")] public CString Label { get; set; }

		public inkStepperData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
