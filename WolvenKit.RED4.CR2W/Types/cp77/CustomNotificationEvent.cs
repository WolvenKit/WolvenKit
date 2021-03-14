using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomNotificationEvent : redEvent
	{
		private CString _header;
		private CString _description;
		private CName _icon;
		private CString _fluff_header;

		[Ordinal(0)] 
		[RED("header")] 
		public CString Header
		{
			get
			{
				if (_header == null)
				{
					_header = (CString) CR2WTypeManager.Create("String", "header", cr2w, this);
				}
				return _header;
			}
			set
			{
				if (_header == value)
				{
					return;
				}
				_header = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("description")] 
		public CString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CString) CR2WTypeManager.Create("String", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public CName Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (CName) CR2WTypeManager.Create("CName", "icon", cr2w, this);
				}
				return _icon;
			}
			set
			{
				if (_icon == value)
				{
					return;
				}
				_icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("fluff_header")] 
		public CString Fluff_header
		{
			get
			{
				if (_fluff_header == null)
				{
					_fluff_header = (CString) CR2WTypeManager.Create("String", "fluff_header", cr2w, this);
				}
				return _fluff_header;
			}
			set
			{
				if (_fluff_header == value)
				{
					return;
				}
				_fluff_header = value;
				PropertySet(this);
			}
		}

		public CustomNotificationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
