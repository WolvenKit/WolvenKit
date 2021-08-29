using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorEventHandlerNodeDefinition : AIbehaviorDecoratorNodeDefinition
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
	}
}
