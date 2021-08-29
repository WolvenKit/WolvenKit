using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimStateTransitionCondition_IntEdgeGreaterFromZeroFeature : animAnimStateTransitionCondition_IntEdgeFeature
	{
		private CInt32 _greaterThenValue;

		[Ordinal(2)] 
		[RED("greaterThenValue")] 
		public CInt32 GreaterThenValue
		{
			get => GetProperty(ref _greaterThenValue);
			set => SetProperty(ref _greaterThenValue, value);
		}
	}
}
