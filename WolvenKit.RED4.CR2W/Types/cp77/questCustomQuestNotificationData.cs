using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCustomQuestNotificationData : CVariable
	{
		private CString _header;
		private CString _desc;
		private CName _icon;
		private CString _fluffHeader;

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
		[RED("desc")] 
		public CString Desc
		{
			get
			{
				if (_desc == null)
				{
					_desc = (CString) CR2WTypeManager.Create("String", "desc", cr2w, this);
				}
				return _desc;
			}
			set
			{
				if (_desc == value)
				{
					return;
				}
				_desc = value;
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
		[RED("fluffHeader")] 
		public CString FluffHeader
		{
			get
			{
				if (_fluffHeader == null)
				{
					_fluffHeader = (CString) CR2WTypeManager.Create("String", "fluffHeader", cr2w, this);
				}
				return _fluffHeader;
			}
			set
			{
				if (_fluffHeader == value)
				{
					return;
				}
				_fluffHeader = value;
				PropertySet(this);
			}
		}

		public questCustomQuestNotificationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
