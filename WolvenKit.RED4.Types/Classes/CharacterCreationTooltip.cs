using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CharacterCreationTooltip : MessageTooltip
	{
		private inkTextWidgetReference _attribiuteLevel;
		private inkTextWidgetReference _maxedOrMinimumLabelText;
		private inkWidgetReference _maxedOrMinimumLabel;
		private inkWidgetReference _attribiuteLevelLabel;

		[Ordinal(5)] 
		[RED("attribiuteLevel")] 
		public inkTextWidgetReference AttribiuteLevel
		{
			get => GetProperty(ref _attribiuteLevel);
			set => SetProperty(ref _attribiuteLevel, value);
		}

		[Ordinal(6)] 
		[RED("maxedOrMinimumLabelText")] 
		public inkTextWidgetReference MaxedOrMinimumLabelText
		{
			get => GetProperty(ref _maxedOrMinimumLabelText);
			set => SetProperty(ref _maxedOrMinimumLabelText, value);
		}

		[Ordinal(7)] 
		[RED("maxedOrMinimumLabel")] 
		public inkWidgetReference MaxedOrMinimumLabel
		{
			get => GetProperty(ref _maxedOrMinimumLabel);
			set => SetProperty(ref _maxedOrMinimumLabel, value);
		}

		[Ordinal(8)] 
		[RED("attribiuteLevelLabel")] 
		public inkWidgetReference AttribiuteLevelLabel
		{
			get => GetProperty(ref _attribiuteLevelLabel);
			set => SetProperty(ref _attribiuteLevelLabel, value);
		}
	}
}
