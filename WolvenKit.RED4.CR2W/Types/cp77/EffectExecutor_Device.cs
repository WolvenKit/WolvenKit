using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_Device : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] [RED("maxDelay")] public CFloat MaxDelay { get; set; }

		public EffectExecutor_Device(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
