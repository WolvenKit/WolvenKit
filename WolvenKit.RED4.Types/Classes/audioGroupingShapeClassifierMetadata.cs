using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioGroupingShapeClassifierMetadata : audioAudioMetadata
	{
		private CBool _useAngle;
		private CFloat _minGroupSize;
		private CFloat _maxGroupSize;
		private CFloat _minGroupAngleSpread;
		private CFloat _maxGroupAngleSpread;
		private CBool _floorLimit;
		private CBool _ceilingLimit;
		private CName _minDistanceLimit;
		private CName _maxDistanceLimit;

		[Ordinal(1)] 
		[RED("useAngle")] 
		public CBool UseAngle
		{
			get => GetProperty(ref _useAngle);
			set => SetProperty(ref _useAngle, value);
		}

		[Ordinal(2)] 
		[RED("minGroupSize")] 
		public CFloat MinGroupSize
		{
			get => GetProperty(ref _minGroupSize);
			set => SetProperty(ref _minGroupSize, value);
		}

		[Ordinal(3)] 
		[RED("maxGroupSize")] 
		public CFloat MaxGroupSize
		{
			get => GetProperty(ref _maxGroupSize);
			set => SetProperty(ref _maxGroupSize, value);
		}

		[Ordinal(4)] 
		[RED("minGroupAngleSpread")] 
		public CFloat MinGroupAngleSpread
		{
			get => GetProperty(ref _minGroupAngleSpread);
			set => SetProperty(ref _minGroupAngleSpread, value);
		}

		[Ordinal(5)] 
		[RED("maxGroupAngleSpread")] 
		public CFloat MaxGroupAngleSpread
		{
			get => GetProperty(ref _maxGroupAngleSpread);
			set => SetProperty(ref _maxGroupAngleSpread, value);
		}

		[Ordinal(6)] 
		[RED("floorLimit")] 
		public CBool FloorLimit
		{
			get => GetProperty(ref _floorLimit);
			set => SetProperty(ref _floorLimit, value);
		}

		[Ordinal(7)] 
		[RED("ceilingLimit")] 
		public CBool CeilingLimit
		{
			get => GetProperty(ref _ceilingLimit);
			set => SetProperty(ref _ceilingLimit, value);
		}

		[Ordinal(8)] 
		[RED("minDistanceLimit")] 
		public CName MinDistanceLimit
		{
			get => GetProperty(ref _minDistanceLimit);
			set => SetProperty(ref _minDistanceLimit, value);
		}

		[Ordinal(9)] 
		[RED("maxDistanceLimit")] 
		public CName MaxDistanceLimit
		{
			get => GetProperty(ref _maxDistanceLimit);
			set => SetProperty(ref _maxDistanceLimit, value);
		}

		public audioGroupingShapeClassifierMetadata()
		{
			_minDistanceLimit = "near";
			_maxDistanceLimit = "infinite";
		}
	}
}
