using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationTooltip : MessageTooltip
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

		public CharacterCreationTooltip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
