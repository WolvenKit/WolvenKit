using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_SendActionSignal : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] [RED("signalName")] public CName SignalName { get; set; }
		[Ordinal(2)] [RED("signalDuration")] public CFloat SignalDuration { get; set; }

		public EffectExecutor_SendActionSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
