using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericMessageNotificationData : inkGameNotificationData
	{
		private CInt32 _identifier;
		private CEnum<GenericMessageNotificationType> _type;
		private CString _title;
		private CString _message;

		[Ordinal(6)] 
		[RED("identifier")] 
		public CInt32 Identifier
		{
			get
			{
				if (_identifier == null)
				{
					_identifier = (CInt32) CR2WTypeManager.Create("Int32", "identifier", cr2w, this);
				}
				return _identifier;
			}
			set
			{
				if (_identifier == value)
				{
					return;
				}
				_identifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("type")] 
		public CEnum<GenericMessageNotificationType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<GenericMessageNotificationType>) CR2WTypeManager.Create("GenericMessageNotificationType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		public GenericMessageNotificationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
