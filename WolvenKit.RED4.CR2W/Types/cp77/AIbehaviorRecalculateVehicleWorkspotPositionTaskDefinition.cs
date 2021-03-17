using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorRecalculateVehicleWorkspotPositionTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _mountData;
		private CHandle<AIArgumentMapping> _workspotData;

		[Ordinal(1)] 
		[RED("mountData")] 
		public CHandle<AIArgumentMapping> MountData
		{
			get => GetProperty(ref _mountData);
			set => SetProperty(ref _mountData, value);
		}

		[Ordinal(2)] 
		[RED("workspotData")] 
		public CHandle<AIArgumentMapping> WorkspotData
		{
			get => GetProperty(ref _workspotData);
			set => SetProperty(ref _workspotData, value);
		}

		public AIbehaviorRecalculateVehicleWorkspotPositionTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
