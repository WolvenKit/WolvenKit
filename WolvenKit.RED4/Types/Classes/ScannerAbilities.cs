using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerAbilities : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("abilities")] 
		public CArray<CWeakHandle<gamedataGameplayAbility_Record>> Abilities
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataGameplayAbility_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataGameplayAbility_Record>>>(value);
		}

		public ScannerAbilities()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
