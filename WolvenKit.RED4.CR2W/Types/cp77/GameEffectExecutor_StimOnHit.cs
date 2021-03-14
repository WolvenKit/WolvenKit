using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameEffectExecutor_StimOnHit : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] [RED("stimType")] public CEnum<gamedataStimType> StimType { get; set; }
		[Ordinal(2)] [RED("silentStimType")] public CEnum<gamedataStimType> SilentStimType { get; set; }

		public GameEffectExecutor_StimOnHit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
