using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetDestinationWaypoint : AIActionHelperTask
	{
		private CEnum<EAITargetType> _refTargetType;
		private CBool _findClosest;
		private CName _waypointsName;
		private CArray<Vector4> _destinations;
		private CArray<Vector4> _finalDestinations;

		[Ordinal(5)] 
		[RED("refTargetType")] 
		public CEnum<EAITargetType> RefTargetType
		{
			get => GetProperty(ref _refTargetType);
			set => SetProperty(ref _refTargetType, value);
		}

		[Ordinal(6)] 
		[RED("findClosest")] 
		public CBool FindClosest
		{
			get => GetProperty(ref _findClosest);
			set => SetProperty(ref _findClosest, value);
		}

		[Ordinal(7)] 
		[RED("waypointsName")] 
		public CName WaypointsName
		{
			get => GetProperty(ref _waypointsName);
			set => SetProperty(ref _waypointsName, value);
		}

		[Ordinal(8)] 
		[RED("destinations")] 
		public CArray<Vector4> Destinations
		{
			get => GetProperty(ref _destinations);
			set => SetProperty(ref _destinations, value);
		}

		[Ordinal(9)] 
		[RED("finalDestinations")] 
		public CArray<Vector4> FinalDestinations
		{
			get => GetProperty(ref _finalDestinations);
			set => SetProperty(ref _finalDestinations, value);
		}

		public SetDestinationWaypoint(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
