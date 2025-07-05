using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerkTooltipDescriptionEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("wrapper")] 
		public inkWidgetReference Wrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(1)] 
		[RED("level")] 
		public inkTextWidgetReference Level
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("text")] 
		public inkTextWidgetReference Text
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("videoLabel")] 
		public inkWidgetReference VideoLabel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("highlightLabel")] 
		public inkWidgetReference HighlightLabel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public PerkTooltipDescriptionEntry()
		{
			Wrapper = new inkWidgetReference();
			Level = new inkTextWidgetReference();
			Text = new inkTextWidgetReference();
			VideoLabel = new inkWidgetReference();
			HighlightLabel = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
