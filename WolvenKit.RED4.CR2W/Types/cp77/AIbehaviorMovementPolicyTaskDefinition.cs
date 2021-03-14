using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMovementPolicyTaskDefinition : AIbehaviorTaskDefinition
	{
		private CBool _useCurrentPolicy;
		private CBool _waitForPolicy;
		private CHandle<AIArgumentMapping> _stopWhenDestinationReached;
		private CArray<CHandle<AIbehaviorMovementPolicyTaskItemDefinition>> _policies;

		[Ordinal(1)] 
		[RED("useCurrentPolicy")] 
		public CBool UseCurrentPolicy
		{
			get
			{
				if (_useCurrentPolicy == null)
				{
					_useCurrentPolicy = (CBool) CR2WTypeManager.Create("Bool", "useCurrentPolicy", cr2w, this);
				}
				return _useCurrentPolicy;
			}
			set
			{
				if (_useCurrentPolicy == value)
				{
					return;
				}
				_useCurrentPolicy = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("waitForPolicy")] 
		public CBool WaitForPolicy
		{
			get
			{
				if (_waitForPolicy == null)
				{
					_waitForPolicy = (CBool) CR2WTypeManager.Create("Bool", "waitForPolicy", cr2w, this);
				}
				return _waitForPolicy;
			}
			set
			{
				if (_waitForPolicy == value)
				{
					return;
				}
				_waitForPolicy = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("stopWhenDestinationReached")] 
		public CHandle<AIArgumentMapping> StopWhenDestinationReached
		{
			get
			{
				if (_stopWhenDestinationReached == null)
				{
					_stopWhenDestinationReached = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "stopWhenDestinationReached", cr2w, this);
				}
				return _stopWhenDestinationReached;
			}
			set
			{
				if (_stopWhenDestinationReached == value)
				{
					return;
				}
				_stopWhenDestinationReached = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("policies")] 
		public CArray<CHandle<AIbehaviorMovementPolicyTaskItemDefinition>> Policies
		{
			get
			{
				if (_policies == null)
				{
					_policies = (CArray<CHandle<AIbehaviorMovementPolicyTaskItemDefinition>>) CR2WTypeManager.Create("array:handle:AIbehaviorMovementPolicyTaskItemDefinition", "policies", cr2w, this);
				}
				return _policies;
			}
			set
			{
				if (_policies == value)
				{
					return;
				}
				_policies = value;
				PropertySet(this);
			}
		}

		public AIbehaviorMovementPolicyTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
