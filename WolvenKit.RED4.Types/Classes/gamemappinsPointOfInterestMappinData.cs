using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamemappinsPointOfInterestMappinData : gamemappinsIMappinData
	{
		private CHandle<gamemappinsIPointOfInterestVariant> _typedVariant;
		private CBool _active;

		[Ordinal(0)] 
		[RED("typedVariant")] 
		public CHandle<gamemappinsIPointOfInterestVariant> TypedVariant
		{
			get => GetProperty(ref _typedVariant);
			set => SetProperty(ref _typedVariant, value);
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}
	}
}
