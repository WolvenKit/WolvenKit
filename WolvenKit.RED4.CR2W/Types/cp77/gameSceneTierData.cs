using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSceneTierData : IScriptable
	{
		private CEnum<GameplayTier> _tier;
		private CBool _emptyHands;

		[Ordinal(0)] 
		[RED("tier")] 
		public CEnum<GameplayTier> Tier
		{
			get => GetProperty(ref _tier);
			set => SetProperty(ref _tier, value);
		}

		[Ordinal(1)] 
		[RED("emptyHands")] 
		public CBool EmptyHands
		{
			get => GetProperty(ref _emptyHands);
			set => SetProperty(ref _emptyHands, value);
		}

		public gameSceneTierData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
