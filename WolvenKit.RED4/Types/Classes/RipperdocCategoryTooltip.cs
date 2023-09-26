using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocCategoryTooltip : AGenericTooltipController
	{
		[Ordinal(2)] 
		[RED("desc")] 
		public inkTextWidgetReference Desc
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("availableLabelCounter")] 
		public inkTextWidgetReference AvailableLabelCounter
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("ownedLabelCounter")] 
		public inkTextWidgetReference OwnedLabelCounter
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("ownedLabel")] 
		public inkWidgetReference OwnedLabel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("availableLabel")] 
		public inkWidgetReference AvailableLabel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("NALabel")] 
		public inkWidgetReference NALabel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public RipperdocCategoryTooltip()
		{
			Desc = new inkTextWidgetReference();
			AvailableLabelCounter = new inkTextWidgetReference();
			OwnedLabelCounter = new inkTextWidgetReference();
			OwnedLabel = new inkWidgetReference();
			AvailableLabel = new inkWidgetReference();
			NALabel = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
