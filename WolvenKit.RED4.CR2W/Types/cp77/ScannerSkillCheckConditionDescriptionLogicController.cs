using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerSkillCheckConditionDescriptionLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _nameRef;
		private CName _passedStateName;
		private CName _failedStateName;

		[Ordinal(1)] 
		[RED("NameRef")] 
		public inkTextWidgetReference NameRef
		{
			get
			{
				if (_nameRef == null)
				{
					_nameRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "NameRef", cr2w, this);
				}
				return _nameRef;
			}
			set
			{
				if (_nameRef == value)
				{
					return;
				}
				_nameRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("PassedStateName")] 
		public CName PassedStateName
		{
			get
			{
				if (_passedStateName == null)
				{
					_passedStateName = (CName) CR2WTypeManager.Create("CName", "PassedStateName", cr2w, this);
				}
				return _passedStateName;
			}
			set
			{
				if (_passedStateName == value)
				{
					return;
				}
				_passedStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("FailedStateName")] 
		public CName FailedStateName
		{
			get
			{
				if (_failedStateName == null)
				{
					_failedStateName = (CName) CR2WTypeManager.Create("CName", "FailedStateName", cr2w, this);
				}
				return _failedStateName;
			}
			set
			{
				if (_failedStateName == value)
				{
					return;
				}
				_failedStateName = value;
				PropertySet(this);
			}
		}

		public ScannerSkillCheckConditionDescriptionLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
