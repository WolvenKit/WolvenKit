using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDisplayMessageBox_NodeType : questIUIManagerNodeType
	{
		private CString _title;
		private CString _message;
		private LocalizationString _localizedTitle;
		private LocalizationString _localizedMessage;

		[Ordinal(0)] 
		[RED("title")] 
		public CString Title
		{
			get
			{
				if (_title == null)
				{
					_title = (CString) CR2WTypeManager.Create("String", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("message")] 
		public CString Message
		{
			get
			{
				if (_message == null)
				{
					_message = (CString) CR2WTypeManager.Create("String", "message", cr2w, this);
				}
				return _message;
			}
			set
			{
				if (_message == value)
				{
					return;
				}
				_message = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("localizedTitle")] 
		public LocalizationString LocalizedTitle
		{
			get
			{
				if (_localizedTitle == null)
				{
					_localizedTitle = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "localizedTitle", cr2w, this);
				}
				return _localizedTitle;
			}
			set
			{
				if (_localizedTitle == value)
				{
					return;
				}
				_localizedTitle = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("localizedMessage")] 
		public LocalizationString LocalizedMessage
		{
			get
			{
				if (_localizedMessage == null)
				{
					_localizedMessage = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "localizedMessage", cr2w, this);
				}
				return _localizedMessage;
			}
			set
			{
				if (_localizedMessage == value)
				{
					return;
				}
				_localizedMessage = value;
				PropertySet(this);
			}
		}

		public questDisplayMessageBox_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
