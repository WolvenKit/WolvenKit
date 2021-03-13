using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecondHeartStatListener : gameScriptStatsListener
	{
		[Ordinal(0)] [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }

		public SecondHeartStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
