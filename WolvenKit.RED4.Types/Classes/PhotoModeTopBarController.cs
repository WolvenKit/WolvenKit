using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PhotoModeTopBarController : inkRadioGroupController
	{
		private CArray<inkWidgetReference> _photoModeTogglesArray;

		[Ordinal(5)] 
		[RED("photoModeTogglesArray")] 
		public CArray<inkWidgetReference> PhotoModeTogglesArray
		{
			get => GetProperty(ref _photoModeTogglesArray);
			set => SetProperty(ref _photoModeTogglesArray, value);
		}
	}
}
