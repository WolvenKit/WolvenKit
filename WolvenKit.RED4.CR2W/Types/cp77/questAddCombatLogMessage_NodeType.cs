using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAddCombatLogMessage_NodeType : questIUIManagerNodeType
	{
		private CString _message;
		private LocalizationString _localizedMessage;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		public questAddCombatLogMessage_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
