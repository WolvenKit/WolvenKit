using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			Abilities = new();
		}
	}
}
