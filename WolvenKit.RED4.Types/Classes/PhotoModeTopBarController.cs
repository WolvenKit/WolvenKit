using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
