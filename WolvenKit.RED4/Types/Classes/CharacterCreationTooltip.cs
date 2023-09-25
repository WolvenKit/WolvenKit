using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CharacterCreationTooltip : MessageTooltip
	{
		[Ordinal(5)] 
		[RED("attribiuteLevel")] 
		public inkTextWidgetReference AttribiuteLevel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("maxedOrMinimumLabelText")] 
		public inkTextWidgetReference MaxedOrMinimumLabelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("maxedOrMinimumLabel")] 
		public inkWidgetReference MaxedOrMinimumLabel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("attribiuteLevelLabel")] 
		public inkWidgetReference AttribiuteLevelLabel
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public CharacterCreationTooltip()
		{
			AttribiuteLevel = new inkTextWidgetReference();
			MaxedOrMinimumLabelText = new inkTextWidgetReference();
			MaxedOrMinimumLabel = new inkWidgetReference();
			AttribiuteLevelLabel = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
