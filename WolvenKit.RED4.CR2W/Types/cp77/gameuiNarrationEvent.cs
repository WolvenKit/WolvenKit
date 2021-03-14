using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiNarrationEvent : CVariable
	{
		private CString _text;
		private CFloat _durationSec;
		private CColor _color;

		[Ordinal(0)] 
		[RED("text")] 
		public CString Text
		{
			get
			{
				if (_text == null)
				{
					_text = (CString) CR2WTypeManager.Create("String", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("color")] 
		public CColor Color
		{
			get
			{
				if (_color == null)
				{
					_color = (CColor) CR2WTypeManager.Create("Color", "color", cr2w, this);
				}
				return _color;
			}
			set
			{
				if (_color == value)
				{
					return;
				}
				_color = value;
				PropertySet(this);
			}
		}

		public gameuiNarrationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
