using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorWaitingMountCommandConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIArgumentMapping> _requestArgument;
		private CName _callbackName;

		[Ordinal(1)] 
		[RED("requestArgument")] 
		public CHandle<AIArgumentMapping> RequestArgument
		{
			get
			{
				if (_requestArgument == null)
				{
					_requestArgument = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "requestArgument", cr2w, this);
				}
				return _requestArgument;
			}
			set
			{
				if (_requestArgument == value)
				{
					return;
				}
				_requestArgument = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("callbackName")] 
		public CName CallbackName
		{
			get
			{
				if (_callbackName == null)
				{
					_callbackName = (CName) CR2WTypeManager.Create("CName", "callbackName", cr2w, this);
				}
				return _callbackName;
			}
			set
			{
				if (_callbackName == value)
				{
					return;
				}
				_callbackName = value;
				PropertySet(this);
			}
		}

		public AIbehaviorWaitingMountCommandConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
