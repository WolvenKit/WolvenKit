using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractiveSign : Device
	{
		private CEnum<SignShape> _signShape;
		private CEnum<SignType> _type;
		private CString _message;

		[Ordinal(86)] 
		[RED("signShape")] 
		public CEnum<SignShape> SignShape
		{
			get
			{
				if (_signShape == null)
				{
					_signShape = (CEnum<SignShape>) CR2WTypeManager.Create("SignShape", "signShape", cr2w, this);
				}
				return _signShape;
			}
			set
			{
				if (_signShape == value)
				{
					return;
				}
				_signShape = value;
				PropertySet(this);
			}
		}

		[Ordinal(87)] 
		[RED("type")] 
		public CEnum<SignType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<SignType>) CR2WTypeManager.Create("SignType", "type", cr2w, this);
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

		[Ordinal(88)] 
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

		public InteractiveSign(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
