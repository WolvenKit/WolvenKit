using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerDescriptionGameController : BaseChunkGameController
	{
		[Ordinal(5)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("customDescriptionText")] 
		public inkTextWidgetReference CustomDescriptionText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("descriptionCallbackID")] 
		public CHandle<redCallbackObject> DescriptionCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(8)] 
		[RED("isValidDescription")] 
		public CBool IsValidDescription
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("isValidCustomDescription")] 
		public CBool IsValidCustomDescription
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ScannerDescriptionGameController()
		{
			DescriptionText = new();
			CustomDescriptionText = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
