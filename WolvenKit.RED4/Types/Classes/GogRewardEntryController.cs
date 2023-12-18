using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GogRewardEntryController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("nameWidget")] 
		public inkWidgetReference NameWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("descriptionWidget")] 
		public inkWidgetReference DescriptionWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("iconImage")] 
		public inkImageWidgetReference IconImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("ep1LabelContainer")] 
		public inkWidgetReference Ep1LabelContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("backgroundWidget")] 
		public inkWidgetReference BackgroundWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("isUnlocked")] 
		public CBool IsUnlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public GogRewardEntryController()
		{
			NameWidget = new inkWidgetReference();
			DescriptionWidget = new inkWidgetReference();
			IconImage = new inkImageWidgetReference();
			Ep1LabelContainer = new inkWidgetReference();
			BackgroundWidget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
