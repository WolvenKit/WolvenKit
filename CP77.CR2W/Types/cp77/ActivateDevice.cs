using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ActivateDevice : ActionBool
	{
		[Ordinal(0)]  [RED("tweakDBChoiceName")] public CString TweakDBChoiceName { get; set; }

		public ActivateDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
