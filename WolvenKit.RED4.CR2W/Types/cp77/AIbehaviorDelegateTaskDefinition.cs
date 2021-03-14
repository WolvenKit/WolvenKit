using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDelegateTaskDefinition : AIbehaviorTaskDefinition
	{
		private AIbehaviorDelegateTaskRef _onActivate;
		private AIbehaviorDelegateTaskRef _onUpdate;
		private AIbehaviorDelegateTaskRef _onDeactivate;

		[Ordinal(1)] 
		[RED("onActivate")] 
		public AIbehaviorDelegateTaskRef OnActivate
		{
			get
			{
				if (_onActivate == null)
				{
					_onActivate = (AIbehaviorDelegateTaskRef) CR2WTypeManager.Create("AIbehaviorDelegateTaskRef", "onActivate", cr2w, this);
				}
				return _onActivate;
			}
			set
			{
				if (_onActivate == value)
				{
					return;
				}
				_onActivate = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("onUpdate")] 
		public AIbehaviorDelegateTaskRef OnUpdate
		{
			get
			{
				if (_onUpdate == null)
				{
					_onUpdate = (AIbehaviorDelegateTaskRef) CR2WTypeManager.Create("AIbehaviorDelegateTaskRef", "onUpdate", cr2w, this);
				}
				return _onUpdate;
			}
			set
			{
				if (_onUpdate == value)
				{
					return;
				}
				_onUpdate = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("onDeactivate")] 
		public AIbehaviorDelegateTaskRef OnDeactivate
		{
			get
			{
				if (_onDeactivate == null)
				{
					_onDeactivate = (AIbehaviorDelegateTaskRef) CR2WTypeManager.Create("AIbehaviorDelegateTaskRef", "onDeactivate", cr2w, this);
				}
				return _onDeactivate;
			}
			set
			{
				if (_onDeactivate == value)
				{
					return;
				}
				_onDeactivate = value;
				PropertySet(this);
			}
		}

		public AIbehaviorDelegateTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
