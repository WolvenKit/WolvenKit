using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LinkController : inkButtonController
	{
		private CString _linkAddress;
		private HDRColor _defaultColor;
		private HDRColor _hoverColor;
		private HDRColor _iGNORED_COLOR;

		[Ordinal(10)] 
		[RED("linkAddress")] 
		public CString LinkAddress
		{
			get
			{
				if (_linkAddress == null)
				{
					_linkAddress = (CString) CR2WTypeManager.Create("String", "linkAddress", cr2w, this);
				}
				return _linkAddress;
			}
			set
			{
				if (_linkAddress == value)
				{
					return;
				}
				_linkAddress = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("defaultColor")] 
		public HDRColor DefaultColor
		{
			get
			{
				if (_defaultColor == null)
				{
					_defaultColor = (HDRColor) CR2WTypeManager.Create("HDRColor", "defaultColor", cr2w, this);
				}
				return _defaultColor;
			}
			set
			{
				if (_defaultColor == value)
				{
					return;
				}
				_defaultColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("hoverColor")] 
		public HDRColor HoverColor
		{
			get
			{
				if (_hoverColor == null)
				{
					_hoverColor = (HDRColor) CR2WTypeManager.Create("HDRColor", "hoverColor", cr2w, this);
				}
				return _hoverColor;
			}
			set
			{
				if (_hoverColor == value)
				{
					return;
				}
				_hoverColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("IGNORED_COLOR")] 
		public HDRColor IGNORED_COLOR
		{
			get
			{
				if (_iGNORED_COLOR == null)
				{
					_iGNORED_COLOR = (HDRColor) CR2WTypeManager.Create("HDRColor", "IGNORED_COLOR", cr2w, this);
				}
				return _iGNORED_COLOR;
			}
			set
			{
				if (_iGNORED_COLOR == value)
				{
					return;
				}
				_iGNORED_COLOR = value;
				PropertySet(this);
			}
		}

		public LinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
