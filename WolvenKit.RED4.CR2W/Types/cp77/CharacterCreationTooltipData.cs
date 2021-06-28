using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationTooltipData : MessageTooltipData
	{
		private CString _attribiuteLevel;
		private CString _maxedOrMinimumLabelText;

		[Ordinal(4)] 
		[RED("attribiuteLevel")] 
		public CString AttribiuteLevel
		{
			get => GetProperty(ref _attribiuteLevel);
			set => SetProperty(ref _attribiuteLevel, value);
		}

		[Ordinal(5)] 
		[RED("maxedOrMinimumLabelText")] 
		public CString MaxedOrMinimumLabelText
		{
			get => GetProperty(ref _maxedOrMinimumLabelText);
			set => SetProperty(ref _maxedOrMinimumLabelText, value);
		}

		public CharacterCreationTooltipData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
