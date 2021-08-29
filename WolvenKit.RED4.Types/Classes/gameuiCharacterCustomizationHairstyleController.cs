using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationHairstyleController : gameuiCharacterCustomizationBodyPartsController
	{
		private CName _headGroupName;

		[Ordinal(3)] 
		[RED("headGroupName")] 
		public CName HeadGroupName
		{
			get => GetProperty(ref _headGroupName);
			set => SetProperty(ref _headGroupName, value);
		}
	}
}
