using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerAbilities : ScannerChunk
	{
		private CArray<CWeakHandle<gamedataGameplayAbility_Record>> _abilities;

		[Ordinal(0)] 
		[RED("abilities")] 
		public CArray<CWeakHandle<gamedataGameplayAbility_Record>> Abilities
		{
			get => GetProperty(ref _abilities);
			set => SetProperty(ref _abilities, value);
		}
	}
}
