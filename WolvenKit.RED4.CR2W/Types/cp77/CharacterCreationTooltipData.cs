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
			get
			{
				if (_attribiuteLevel == null)
				{
					_attribiuteLevel = (CString) CR2WTypeManager.Create("String", "attribiuteLevel", cr2w, this);
				}
				return _attribiuteLevel;
			}
			set
			{
				if (_attribiuteLevel == value)
				{
					return;
				}
				_attribiuteLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("maxedOrMinimumLabelText")] 
		public CString MaxedOrMinimumLabelText
		{
			get
			{
				if (_maxedOrMinimumLabelText == null)
				{
					_maxedOrMinimumLabelText = (CString) CR2WTypeManager.Create("String", "maxedOrMinimumLabelText", cr2w, this);
				}
				return _maxedOrMinimumLabelText;
			}
			set
			{
				if (_maxedOrMinimumLabelText == value)
				{
					return;
				}
				_maxedOrMinimumLabelText = value;
				PropertySet(this);
			}
		}

		public CharacterCreationTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
