using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFindPositionAroundSelf : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _distanceMin;
		private CHandle<AIArgumentMapping> _distanceMax;
		private CFloat _angle;
		private CFloat _angleOffset;
		private CHandle<AIArgumentMapping> _outPositionArgument;
		private Vector4 _finalPosition;

		[Ordinal(0)] 
		[RED("distanceMin")] 
		public CHandle<AIArgumentMapping> DistanceMin
		{
			get => GetProperty(ref _distanceMin);
			set => SetProperty(ref _distanceMin, value);
		}

		[Ordinal(1)] 
		[RED("distanceMax")] 
		public CHandle<AIArgumentMapping> DistanceMax
		{
			get => GetProperty(ref _distanceMax);
			set => SetProperty(ref _distanceMax, value);
		}

		[Ordinal(2)] 
		[RED("angle")] 
		public CFloat Angle
		{
			get => GetProperty(ref _angle);
			set => SetProperty(ref _angle, value);
		}

		[Ordinal(3)] 
		[RED("angleOffset")] 
		public CFloat AngleOffset
		{
			get => GetProperty(ref _angleOffset);
			set => SetProperty(ref _angleOffset, value);
		}

		[Ordinal(4)] 
		[RED("outPositionArgument")] 
		public CHandle<AIArgumentMapping> OutPositionArgument
		{
			get => GetProperty(ref _outPositionArgument);
			set => SetProperty(ref _outPositionArgument, value);
		}

		[Ordinal(5)] 
		[RED("finalPosition")] 
		public Vector4 FinalPosition
		{
			get => GetProperty(ref _finalPosition);
			set => SetProperty(ref _finalPosition, value);
		}

		public AIFindPositionAroundSelf(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
