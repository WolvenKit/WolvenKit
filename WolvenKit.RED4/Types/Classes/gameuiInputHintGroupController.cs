using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiInputHintGroupController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("titleTextRef")] 
		public inkTextWidgetReference TitleTextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("descriptionTextRef")] 
		public inkTextWidgetReference DescriptionTextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("hintsContainerRef")] 
		public inkCompoundWidgetReference HintsContainerRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("iconRef")] 
		public inkImageWidgetReference IconRef
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public gameuiInputHintGroupController()
		{
			TitleTextRef = new inkTextWidgetReference();
			DescriptionTextRef = new inkTextWidgetReference();
			HintsContainerRef = new inkCompoundWidgetReference();
			IconRef = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
