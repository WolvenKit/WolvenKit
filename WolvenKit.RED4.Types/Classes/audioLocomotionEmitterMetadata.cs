using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioLocomotionEmitterMetadata : audioEmitterMetadata
	{
		private CName _customMaterialLookup;
		private CBool _isPlayer;

		[Ordinal(1)] 
		[RED("customMaterialLookup")] 
		public CName CustomMaterialLookup
		{
			get => GetProperty(ref _customMaterialLookup);
			set => SetProperty(ref _customMaterialLookup, value);
		}

		[Ordinal(2)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}
	}
}
