using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AssignRestrictMovementAreaHandler : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _inCommand;
		private CEnum<AIbehaviorCompletionStatus> _resultOnNoChange;

		[Ordinal(0)] 
		[RED("inCommand")] 
		public CHandle<AIArgumentMapping> InCommand
		{
			get
			{
				if (_inCommand == null)
				{
					_inCommand = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "inCommand", cr2w, this);
				}
				return _inCommand;
			}
			set
			{
				if (_inCommand == value)
				{
					return;
				}
				_inCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("resultOnNoChange")] 
		public CEnum<AIbehaviorCompletionStatus> ResultOnNoChange
		{
			get
			{
				if (_resultOnNoChange == null)
				{
					_resultOnNoChange = (CEnum<AIbehaviorCompletionStatus>) CR2WTypeManager.Create("AIbehaviorCompletionStatus", "resultOnNoChange", cr2w, this);
				}
				return _resultOnNoChange;
			}
			set
			{
				if (_resultOnNoChange == value)
				{
					return;
				}
				_resultOnNoChange = value;
				PropertySet(this);
			}
		}

		public AssignRestrictMovementAreaHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
