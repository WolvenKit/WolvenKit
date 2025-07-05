using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerkScreenTierInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("wrapper")] 
		public inkWidgetReference Wrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(1)] 
		[RED("requirementText")] 
		public inkTextWidgetReference RequirementText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("attributeLevelWrapper")] 
		public inkWidgetReference AttributeLevelWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("highlightWidget")] 
		public inkWidgetReference HighlightWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("unlocked")] 
		public CBool Unlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PerkScreenTierInfo()
		{
			Wrapper = new inkWidgetReference();
			RequirementText = new inkTextWidgetReference();
			AttributeLevelWrapper = new inkWidgetReference();
			HighlightWidget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
