using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription : RedBaseClass
	{
		private CName _name;
		private CFloat _minValue;
		private CFloat _maxValue;
		private CUInt32 _gridDivisionsCount;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("minValue")] 
		public CFloat MinValue
		{
			get => GetProperty(ref _minValue);
			set => SetProperty(ref _minValue, value);
		}

		[Ordinal(2)] 
		[RED("maxValue")] 
		public CFloat MaxValue
		{
			get => GetProperty(ref _maxValue);
			set => SetProperty(ref _maxValue, value);
		}

		[Ordinal(3)] 
		[RED("gridDivisionsCount")] 
		public CUInt32 GridDivisionsCount
		{
			get => GetProperty(ref _gridDivisionsCount);
			set => SetProperty(ref _gridDivisionsCount, value);
		}
	}
}
