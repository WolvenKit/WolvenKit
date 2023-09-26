using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocPerkData : IScriptable
	{
		[Ordinal(0)] 
		[RED("Perk")] 
		public TweakDBID Perk
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("Area")] 
		public CEnum<gamedataNewPerkSlotType> Area
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkSlotType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkSlotType>>(value);
		}

		[Ordinal(2)] 
		[RED("Level")] 
		public CInt32 Level
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public RipperdocPerkData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
