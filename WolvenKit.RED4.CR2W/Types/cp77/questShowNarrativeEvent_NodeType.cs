using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questShowNarrativeEvent_NodeType : questIUIManagerNodeType
	{
		private CString _eventText;
		private CColor _textColor;
		private CFloat _durationSec;

		[Ordinal(0)] 
		[RED("eventText")] 
		public CString EventText
		{
			get
			{
				if (_eventText == null)
				{
					_eventText = (CString) CR2WTypeManager.Create("String", "eventText", cr2w, this);
				}
				return _eventText;
			}
			set
			{
				if (_eventText == value)
				{
					return;
				}
				_eventText = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("textColor")] 
		public CColor TextColor
		{
			get
			{
				if (_textColor == null)
				{
					_textColor = (CColor) CR2WTypeManager.Create("Color", "textColor", cr2w, this);
				}
				return _textColor;
			}
			set
			{
				if (_textColor == value)
				{
					return;
				}
				_textColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("durationSec")] 
		public CFloat DurationSec
		{
			get
			{
				if (_durationSec == null)
				{
					_durationSec = (CFloat) CR2WTypeManager.Create("Float", "durationSec", cr2w, this);
				}
				return _durationSec;
			}
			set
			{
				if (_durationSec == value)
				{
					return;
				}
				_durationSec = value;
				PropertySet(this);
			}
		}

		public questShowNarrativeEvent_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
