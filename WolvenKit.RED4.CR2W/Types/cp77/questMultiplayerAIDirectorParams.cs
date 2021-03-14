using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerAIDirectorParams : ISerializable
	{
		private CEnum<questMultiplayerAIDirectorFunction> _function;
		private CEnum<questMultiplayerAIDirectorStatus> _status;
		private NodeRef _pathRef;
		private CString _scheduleEntryName;
		private CString _scheduleName;

		[Ordinal(0)] 
		[RED("function")] 
		public CEnum<questMultiplayerAIDirectorFunction> Function
		{
			get
			{
				if (_function == null)
				{
					_function = (CEnum<questMultiplayerAIDirectorFunction>) CR2WTypeManager.Create("questMultiplayerAIDirectorFunction", "function", cr2w, this);
				}
				return _function;
			}
			set
			{
				if (_function == value)
				{
					return;
				}
				_function = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("status")] 
		public CEnum<questMultiplayerAIDirectorStatus> Status
		{
			get
			{
				if (_status == null)
				{
					_status = (CEnum<questMultiplayerAIDirectorStatus>) CR2WTypeManager.Create("questMultiplayerAIDirectorStatus", "status", cr2w, this);
				}
				return _status;
			}
			set
			{
				if (_status == value)
				{
					return;
				}
				_status = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("pathRef")] 
		public NodeRef PathRef
		{
			get
			{
				if (_pathRef == null)
				{
					_pathRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "pathRef", cr2w, this);
				}
				return _pathRef;
			}
			set
			{
				if (_pathRef == value)
				{
					return;
				}
				_pathRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("scheduleEntryName")] 
		public CString ScheduleEntryName
		{
			get
			{
				if (_scheduleEntryName == null)
				{
					_scheduleEntryName = (CString) CR2WTypeManager.Create("String", "scheduleEntryName", cr2w, this);
				}
				return _scheduleEntryName;
			}
			set
			{
				if (_scheduleEntryName == value)
				{
					return;
				}
				_scheduleEntryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("scheduleName")] 
		public CString ScheduleName
		{
			get
			{
				if (_scheduleName == null)
				{
					_scheduleName = (CString) CR2WTypeManager.Create("String", "scheduleName", cr2w, this);
				}
				return _scheduleName;
			}
			set
			{
				if (_scheduleName == value)
				{
					return;
				}
				_scheduleName = value;
				PropertySet(this);
			}
		}

		public questMultiplayerAIDirectorParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
