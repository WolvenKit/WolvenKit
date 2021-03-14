using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorEventHandlerNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CName _eventName;
		private CHandle<AIbehaviorEventResolverDefinition> _resolver;

		[Ordinal(1)] 
		[RED("eventName")] 
		public CName EventName
		{
			get
			{
				if (_eventName == null)
				{
					_eventName = (CName) CR2WTypeManager.Create("CName", "eventName", cr2w, this);
				}
				return _eventName;
			}
			set
			{
				if (_eventName == value)
				{
					return;
				}
				_eventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("resolver")] 
		public CHandle<AIbehaviorEventResolverDefinition> Resolver
		{
			get
			{
				if (_resolver == null)
				{
					_resolver = (CHandle<AIbehaviorEventResolverDefinition>) CR2WTypeManager.Create("handle:AIbehaviorEventResolverDefinition", "resolver", cr2w, this);
				}
				return _resolver;
			}
			set
			{
				if (_resolver == value)
				{
					return;
				}
				_resolver = value;
				PropertySet(this);
			}
		}

		public AIbehaviorEventHandlerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
