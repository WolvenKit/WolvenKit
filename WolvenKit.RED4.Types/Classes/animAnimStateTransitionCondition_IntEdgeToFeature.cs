using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimStateTransitionCondition_IntEdgeToFeature : animAnimStateTransitionCondition_IntEdgeFeature
	{
		private CInt32 _toValue;

		[Ordinal(2)] 
		[RED("toValue")] 
		public CInt32 ToValue
		{
			get => GetProperty(ref _toValue);
			set => SetProperty(ref _toValue, value);
		}
	}
}
