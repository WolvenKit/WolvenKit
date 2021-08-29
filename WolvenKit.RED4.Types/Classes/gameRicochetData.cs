using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameRicochetData : RedBaseClass
	{
		private CInt32 _count;
		private CFloat _range;
		private CFloat _targetSearchAngle;
		private CFloat _minAngle;
		private CFloat _maxAngle;
		private CFloat _chance;

		[Ordinal(0)] 
		[RED("count")] 
		public CInt32 Count
		{
			get => GetProperty(ref _count);
			set => SetProperty(ref _count, value);
		}

		[Ordinal(1)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(2)] 
		[RED("targetSearchAngle")] 
		public CFloat TargetSearchAngle
		{
			get => GetProperty(ref _targetSearchAngle);
			set => SetProperty(ref _targetSearchAngle, value);
		}

		[Ordinal(3)] 
		[RED("minAngle")] 
		public CFloat MinAngle
		{
			get => GetProperty(ref _minAngle);
			set => SetProperty(ref _minAngle, value);
		}

		[Ordinal(4)] 
		[RED("maxAngle")] 
		public CFloat MaxAngle
		{
			get => GetProperty(ref _maxAngle);
			set => SetProperty(ref _maxAngle, value);
		}

		[Ordinal(5)] 
		[RED("chance")] 
		public CFloat Chance
		{
			get => GetProperty(ref _chance);
			set => SetProperty(ref _chance, value);
		}
	}
}
