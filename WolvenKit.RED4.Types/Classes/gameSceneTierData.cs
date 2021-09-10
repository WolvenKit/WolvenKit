using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSceneTierData : IScriptable
	{
		[Ordinal(0)] 
		[RED("tier")] 
		public CEnum<GameplayTier> Tier
		{
			get => GetPropertyValue<CEnum<GameplayTier>>();
			set => SetPropertyValue<CEnum<GameplayTier>>(value);
		}

		[Ordinal(1)] 
		[RED("emptyHands")] 
		public CBool EmptyHands
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
