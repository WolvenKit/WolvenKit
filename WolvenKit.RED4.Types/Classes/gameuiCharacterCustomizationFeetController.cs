using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationFeetController : gameuiCharacterCustomizationBodyPartsController
	{
		private CName _liftedFeetGroupName;
		private CName _flatFeetGroupName;

		[Ordinal(3)] 
		[RED("liftedFeetGroupName")] 
		public CName LiftedFeetGroupName
		{
			get => GetProperty(ref _liftedFeetGroupName);
			set => SetProperty(ref _liftedFeetGroupName, value);
		}

		[Ordinal(4)] 
		[RED("flatFeetGroupName")] 
		public CName FlatFeetGroupName
		{
			get => GetProperty(ref _flatFeetGroupName);
			set => SetProperty(ref _flatFeetGroupName, value);
		}
	}
}
