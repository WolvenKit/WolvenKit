using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HasPositionFarFromThreat : AIbehaviorconditionScript
	{
		private CFloat _desiredDistance;
		private CFloat _minDistance;
		private CFloat _minPathLength;
		private CFloat _distanceFromTraffic;

		[Ordinal(0)] 
		[RED("desiredDistance")] 
		public CFloat DesiredDistance
		{
			get => GetProperty(ref _desiredDistance);
			set => SetProperty(ref _desiredDistance, value);
		}

		[Ordinal(1)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get => GetProperty(ref _minDistance);
			set => SetProperty(ref _minDistance, value);
		}

		[Ordinal(2)] 
		[RED("minPathLength")] 
		public CFloat MinPathLength
		{
			get => GetProperty(ref _minPathLength);
			set => SetProperty(ref _minPathLength, value);
		}

		[Ordinal(3)] 
		[RED("distanceFromTraffic")] 
		public CFloat DistanceFromTraffic
		{
			get => GetProperty(ref _distanceFromTraffic);
			set => SetProperty(ref _distanceFromTraffic, value);
		}

		public HasPositionFarFromThreat(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
