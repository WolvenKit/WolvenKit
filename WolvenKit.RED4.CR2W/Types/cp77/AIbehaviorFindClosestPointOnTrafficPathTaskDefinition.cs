using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFindClosestPointOnTrafficPathTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _enterClosest;
		private CHandle<AIArgumentMapping> _avoidedPosition;
		private CHandle<AIArgumentMapping> _avoidedPositionDistance;
		private CHandle<AIArgumentMapping> _usePreviousPosition;
		private CHandle<AIArgumentMapping> _checkRoadIntersection;
		private CHandle<AIArgumentMapping> _workspotData;
		private CHandle<AIArgumentMapping> _positionOnPath;
		private CHandle<AIArgumentMapping> _pathDirection;
		private CHandle<AIArgumentMapping> _joinTrafficSettings;

		[Ordinal(1)] 
		[RED("enterClosest")] 
		public CHandle<AIArgumentMapping> EnterClosest
		{
			get => GetProperty(ref _enterClosest);
			set => SetProperty(ref _enterClosest, value);
		}

		[Ordinal(2)] 
		[RED("avoidedPosition")] 
		public CHandle<AIArgumentMapping> AvoidedPosition
		{
			get => GetProperty(ref _avoidedPosition);
			set => SetProperty(ref _avoidedPosition, value);
		}

		[Ordinal(3)] 
		[RED("avoidedPositionDistance")] 
		public CHandle<AIArgumentMapping> AvoidedPositionDistance
		{
			get => GetProperty(ref _avoidedPositionDistance);
			set => SetProperty(ref _avoidedPositionDistance, value);
		}

		[Ordinal(4)] 
		[RED("usePreviousPosition")] 
		public CHandle<AIArgumentMapping> UsePreviousPosition
		{
			get => GetProperty(ref _usePreviousPosition);
			set => SetProperty(ref _usePreviousPosition, value);
		}

		[Ordinal(5)] 
		[RED("checkRoadIntersection")] 
		public CHandle<AIArgumentMapping> CheckRoadIntersection
		{
			get => GetProperty(ref _checkRoadIntersection);
			set => SetProperty(ref _checkRoadIntersection, value);
		}

		[Ordinal(6)] 
		[RED("workspotData")] 
		public CHandle<AIArgumentMapping> WorkspotData
		{
			get => GetProperty(ref _workspotData);
			set => SetProperty(ref _workspotData, value);
		}

		[Ordinal(7)] 
		[RED("positionOnPath")] 
		public CHandle<AIArgumentMapping> PositionOnPath
		{
			get => GetProperty(ref _positionOnPath);
			set => SetProperty(ref _positionOnPath, value);
		}

		[Ordinal(8)] 
		[RED("pathDirection")] 
		public CHandle<AIArgumentMapping> PathDirection
		{
			get => GetProperty(ref _pathDirection);
			set => SetProperty(ref _pathDirection, value);
		}

		[Ordinal(9)] 
		[RED("joinTrafficSettings")] 
		public CHandle<AIArgumentMapping> JoinTrafficSettings
		{
			get => GetProperty(ref _joinTrafficSettings);
			set => SetProperty(ref _joinTrafficSettings, value);
		}

		public AIbehaviorFindClosestPointOnTrafficPathTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
