using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionUseCommunityWorkspotNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _workspotData;
		private CHandle<AIArgumentMapping> _dependentWorkspotData;
		private CHandle<AIArgumentMapping> _playExitAutomatically;
		private CHandle<AIArgumentMapping> _fastForwardAfterTeleport;

		[Ordinal(1)] 
		[RED("workspotData")] 
		public CHandle<AIArgumentMapping> WorkspotData
		{
			get => GetProperty(ref _workspotData);
			set => SetProperty(ref _workspotData, value);
		}

		[Ordinal(2)] 
		[RED("dependentWorkspotData")] 
		public CHandle<AIArgumentMapping> DependentWorkspotData
		{
			get => GetProperty(ref _dependentWorkspotData);
			set => SetProperty(ref _dependentWorkspotData, value);
		}

		[Ordinal(3)] 
		[RED("playExitAutomatically")] 
		public CHandle<AIArgumentMapping> PlayExitAutomatically
		{
			get => GetProperty(ref _playExitAutomatically);
			set => SetProperty(ref _playExitAutomatically, value);
		}

		[Ordinal(4)] 
		[RED("fastForwardAfterTeleport")] 
		public CHandle<AIArgumentMapping> FastForwardAfterTeleport
		{
			get => GetProperty(ref _fastForwardAfterTeleport);
			set => SetProperty(ref _fastForwardAfterTeleport, value);
		}

		public AIbehaviorActionUseCommunityWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
