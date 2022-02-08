using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PhotoModeTopBarController : inkRadioGroupController
	{
		[Ordinal(5)] 
		[RED("photoModeTogglesArray")] 
		public CArray<inkWidgetReference> PhotoModeTogglesArray
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		public PhotoModeTopBarController()
		{
			PhotoModeTogglesArray = new();
		}
	}
}
