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
			get => GetProperty(ref _eventName);
			set => SetProperty(ref _eventName, value);
		}

		[Ordinal(2)] 
		[RED("resolver")] 
		public CHandle<AIbehaviorEventResolverDefinition> Resolver
		{
			get => GetProperty(ref _resolver);
			set => SetProperty(ref _resolver, value);
		}

		public AIbehaviorEventHandlerNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
