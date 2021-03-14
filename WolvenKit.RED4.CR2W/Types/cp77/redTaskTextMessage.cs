using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class redTaskTextMessage : CVariable
	{
		private CUInt32 _taskId;
		private CString _text;
		private CEnum<redTaskTextMessageType> _type;

		[Ordinal(0)] 
		[RED("taskId")] 
		public CUInt32 TaskId
		{
			get
			{
				if (_taskId == null)
				{
					_taskId = (CUInt32) CR2WTypeManager.Create("Uint32", "taskId", cr2w, this);
				}
				return _taskId;
			}
			set
			{
				if (_taskId == value)
				{
					return;
				}
				_taskId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<redTaskTextMessageType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<redTaskTextMessageType>) CR2WTypeManager.Create("redTaskTextMessageType", "type", cr2w, this);
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

		public redTaskTextMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
