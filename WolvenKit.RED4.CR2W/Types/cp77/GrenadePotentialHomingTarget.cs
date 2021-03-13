using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GrenadePotentialHomingTarget : CVariable
	{
		[Ordinal(0)] [RED("entity")] public wCHandle<ScriptedPuppet> Entity { get; set; }
		[Ordinal(1)] [RED("targetSlot")] public CName TargetSlot { get; set; }

		public GrenadePotentialHomingTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
