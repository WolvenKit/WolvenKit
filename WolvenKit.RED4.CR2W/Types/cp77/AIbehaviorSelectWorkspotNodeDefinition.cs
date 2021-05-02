using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSelectWorkspotNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CHandle<AIArgumentMapping> _spotInstance;
		private CHandle<AIArgumentMapping> _workspotData;
		private CHandle<AIArgumentMapping> _dependentWorkspotData;
		private CBool _repeatChild;
		private CHandle<AIArgumentMapping> _fastForwardAfterTeleport;

		[Ordinal(1)] 
		[RED("spotInstance")] 
		public CHandle<AIArgumentMapping> SpotInstance
		{
			get => GetProperty(ref _spotInstance);
			set => SetProperty(ref _spotInstance, value);
		}

		[Ordinal(2)] 
		[RED("workspotData")] 
		public CHandle<AIArgumentMapping> WorkspotData
		{
			get => GetProperty(ref _workspotData);
			set => SetProperty(ref _workspotData, value);
		}

		[Ordinal(3)] 
		[RED("dependentWorkspotData")] 
		public CHandle<AIArgumentMapping> DependentWorkspotData
		{
			get => GetProperty(ref _dependentWorkspotData);
			set => SetProperty(ref _dependentWorkspotData, value);
		}

		[Ordinal(4)] 
		[RED("repeatChild")] 
		public CBool RepeatChild
		{
			get => GetProperty(ref _repeatChild);
			set => SetProperty(ref _repeatChild, value);
		}

		[Ordinal(5)] 
		[RED("fastForwardAfterTeleport")] 
		public CHandle<AIArgumentMapping> FastForwardAfterTeleport
		{
			get => GetProperty(ref _fastForwardAfterTeleport);
			set => SetProperty(ref _fastForwardAfterTeleport, value);
		}

		public AIbehaviorSelectWorkspotNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
