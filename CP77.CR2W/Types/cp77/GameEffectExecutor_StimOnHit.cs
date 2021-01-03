using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GameEffectExecutor_StimOnHit : gameEffectExecutor_Scripted
	{
		[Ordinal(0)]  [RED("silentStimType")] public CEnum<gamedataStimType> SilentStimType { get; set; }
		[Ordinal(1)]  [RED("stimType")] public CEnum<gamedataStimType> StimType { get; set; }

		public GameEffectExecutor_StimOnHit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
