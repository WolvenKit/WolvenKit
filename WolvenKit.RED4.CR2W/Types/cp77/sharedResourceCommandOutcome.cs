using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sharedResourceCommandOutcome : CVariable
	{
		private CEnum<sharedCommandResult> _result;
		private CArray<CString> _modifiedFiles;
		private CString _message;

		[Ordinal(0)] 
		[RED("result")] 
		public CEnum<sharedCommandResult> Result
		{
			get
			{
				if (_result == null)
				{
					_result = (CEnum<sharedCommandResult>) CR2WTypeManager.Create("sharedCommandResult", "result", cr2w, this);
				}
				return _result;
			}
			set
			{
				if (_result == value)
				{
					return;
				}
				_result = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("modifiedFiles")] 
		public CArray<CString> ModifiedFiles
		{
			get
			{
				if (_modifiedFiles == null)
				{
					_modifiedFiles = (CArray<CString>) CR2WTypeManager.Create("array:String", "modifiedFiles", cr2w, this);
				}
				return _modifiedFiles;
			}
			set
			{
				if (_modifiedFiles == value)
				{
					return;
				}
				_modifiedFiles = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public sharedResourceCommandOutcome(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
