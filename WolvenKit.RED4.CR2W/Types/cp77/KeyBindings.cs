using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KeyBindings : CVariable
	{
		[Ordinal(0)] [RED("DPAD_UP")] public TweakDBID DPAD_UP { get; set; }
		[Ordinal(1)] [RED("RB")] public TweakDBID RB { get; set; }

		public KeyBindings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
