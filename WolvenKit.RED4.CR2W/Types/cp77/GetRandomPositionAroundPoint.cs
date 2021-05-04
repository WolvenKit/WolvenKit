using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GetRandomPositionAroundPoint : AIRandomTasks
	{
		private CHandle<AIArgumentMapping> _originPoint;
		private CHandle<AIArgumentMapping> _distanceMin;
		private CHandle<AIArgumentMapping> _distanceMax;
		private CHandle<AIArgumentMapping> _angleMin;
		private CHandle<AIArgumentMapping> _angleMax;
		private CHandle<AIArgumentMapping> _outPositionArgument;
		private Vector4 _finalPosition;

		[Ordinal(0)] 
		[RED("originPoint")] 
		public CHandle<AIArgumentMapping> OriginPoint
		{
			get => GetProperty(ref _originPoint);
			set => SetProperty(ref _originPoint, value);
		}

		[Ordinal(1)] 
		[RED("distanceMin")] 
		public CHandle<AIArgumentMapping> DistanceMin
		{
			get => GetProperty(ref _distanceMin);
			set => SetProperty(ref _distanceMin, value);
		}

		[Ordinal(2)] 
		[RED("distanceMax")] 
		public CHandle<AIArgumentMapping> DistanceMax
		{
			get => GetProperty(ref _distanceMax);
			set => SetProperty(ref _distanceMax, value);
		}

		[Ordinal(3)] 
		[RED("angleMin")] 
		public CHandle<AIArgumentMapping> AngleMin
		{
			get => GetProperty(ref _angleMin);
			set => SetProperty(ref _angleMin, value);
		}

		[Ordinal(4)] 
		[RED("angleMax")] 
		public CHandle<AIArgumentMapping> AngleMax
		{
			get => GetProperty(ref _angleMax);
			set => SetProperty(ref _angleMax, value);
		}

		[Ordinal(5)] 
		[RED("outPositionArgument")] 
		public CHandle<AIArgumentMapping> OutPositionArgument
		{
			get => GetProperty(ref _outPositionArgument);
			set => SetProperty(ref _outPositionArgument, value);
		}

		[Ordinal(6)] 
		[RED("finalPosition")] 
		public Vector4 FinalPosition
		{
			get => GetProperty(ref _finalPosition);
			set => SetProperty(ref _finalPosition, value);
		}

		public GetRandomPositionAroundPoint(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
