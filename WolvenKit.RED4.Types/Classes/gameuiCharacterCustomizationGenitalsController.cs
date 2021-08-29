using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationGenitalsController : gameuiCharacterCustomizationBodyPartsController
	{
		private CName _upperBodyGroupName;
		private CName _bottomBodyGroupName;
		private CBool _forceHideGenitals;

		[Ordinal(3)] 
		[RED("upperBodyGroupName")] 
		public CName UpperBodyGroupName
		{
			get => GetProperty(ref _upperBodyGroupName);
			set => SetProperty(ref _upperBodyGroupName, value);
		}

		[Ordinal(4)] 
		[RED("bottomBodyGroupName")] 
		public CName BottomBodyGroupName
		{
			get => GetProperty(ref _bottomBodyGroupName);
			set => SetProperty(ref _bottomBodyGroupName, value);
		}

		[Ordinal(5)] 
		[RED("forceHideGenitals")] 
		public CBool ForceHideGenitals
		{
			get => GetProperty(ref _forceHideGenitals);
			set => SetProperty(ref _forceHideGenitals, value);
		}
	}
}
