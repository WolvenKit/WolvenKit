using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSceneTierData : IScriptable
	{
		[Ordinal(0)] [RED("tier")] public CEnum<GameplayTier> Tier { get; set; }
		[Ordinal(1)] [RED("emptyHands")] public CBool EmptyHands { get; set; }

		public gameSceneTierData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
