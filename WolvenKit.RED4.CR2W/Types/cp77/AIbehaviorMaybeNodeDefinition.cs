using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMaybeNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CEnum<AIbehaviorMaybeNodeAction> _onChildSuccess;
		private CEnum<AIbehaviorMaybeNodeAction> _onChildFailure;

		[Ordinal(1)] 
		[RED("onChildSuccess")] 
		public CEnum<AIbehaviorMaybeNodeAction> OnChildSuccess
		{
			get
			{
				if (_onChildSuccess == null)
				{
					_onChildSuccess = (CEnum<AIbehaviorMaybeNodeAction>) CR2WTypeManager.Create("AIbehaviorMaybeNodeAction", "onChildSuccess", cr2w, this);
				}
				return _onChildSuccess;
			}
			set
			{
				if (_onChildSuccess == value)
				{
					return;
				}
				_onChildSuccess = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("onChildFailure")] 
		public CEnum<AIbehaviorMaybeNodeAction> OnChildFailure
		{
			get
			{
				if (_onChildFailure == null)
				{
					_onChildFailure = (CEnum<AIbehaviorMaybeNodeAction>) CR2WTypeManager.Create("AIbehaviorMaybeNodeAction", "onChildFailure", cr2w, this);
				}
				return _onChildFailure;
			}
			set
			{
				if (_onChildFailure == value)
				{
					return;
				}
				_onChildFailure = value;
				PropertySet(this);
			}
		}

		public AIbehaviorMaybeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
