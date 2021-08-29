using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorSelectWorkspotEntryTaskDefinition : AIbehaviorTaskDefinition
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
	}
}
