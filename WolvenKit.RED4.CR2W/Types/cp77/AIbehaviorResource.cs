using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorResource : CResource
	{
		private CHandle<AIbehaviorTreeNodeDefinition> _root;
		private AITreeArgumentsDefinition _arguments;
		private CHandle<AIbehaviorBehaviorDelegate> _delegate;
		private CArray<CName> _initializationEvents;

		[Ordinal(1)] 
		[RED("root")] 
		public CHandle<AIbehaviorTreeNodeDefinition> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(2)] 
		[RED("arguments")] 
		public AITreeArgumentsDefinition Arguments
		{
			get => GetProperty(ref _arguments);
			set => SetProperty(ref _arguments, value);
		}

		[Ordinal(3)] 
		[RED("delegate")] 
		public CHandle<AIbehaviorBehaviorDelegate> Delegate
		{
			get => GetProperty(ref _delegate);
			set => SetProperty(ref _delegate, value);
		}

		[Ordinal(4)] 
		[RED("initializationEvents")] 
		public CArray<CName> InitializationEvents
		{
			get => GetProperty(ref _initializationEvents);
			set => SetProperty(ref _initializationEvents, value);
		}

		public AIbehaviorResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
