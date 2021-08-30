using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questDestruction_ConditionType : questIObjectConditionType
	{
		private gameEntityReference _objectRef;
		private CFloat _threshold;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("threshold")] 
		public CFloat Threshold
		{
			get => GetProperty(ref _threshold);
			set => SetProperty(ref _threshold, value);
		}

		public questDestruction_ConditionType()
		{
			_threshold = 50.000000F;
		}
	}
}
