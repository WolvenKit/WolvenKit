using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSelectWorkspotEntryTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _workspotData;
		private CHandle<AIArgumentMapping> _destinationPosition;
		private CHandle<AIArgumentMapping> _tangentPoint;
		private CHandle<AIArgumentMapping> _entranceFromStand;

		[Ordinal(1)] 
		[RED("workspotData")] 
		public CHandle<AIArgumentMapping> WorkspotData
		{
			get => GetProperty(ref _workspotData);
			set => SetProperty(ref _workspotData, value);
		}

		[Ordinal(2)] 
		[RED("destinationPosition")] 
		public CHandle<AIArgumentMapping> DestinationPosition
		{
			get => GetProperty(ref _destinationPosition);
			set => SetProperty(ref _destinationPosition, value);
		}

		[Ordinal(3)] 
		[RED("tangentPoint")] 
		public CHandle<AIArgumentMapping> TangentPoint
		{
			get => GetProperty(ref _tangentPoint);
			set => SetProperty(ref _tangentPoint, value);
		}

		[Ordinal(4)] 
		[RED("entranceFromStand")] 
		public CHandle<AIArgumentMapping> EntranceFromStand
		{
			get => GetProperty(ref _entranceFromStand);
			set => SetProperty(ref _entranceFromStand, value);
		}

		public AIbehaviorSelectWorkspotEntryTaskDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
