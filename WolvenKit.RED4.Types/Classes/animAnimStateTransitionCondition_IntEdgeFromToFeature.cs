using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimStateTransitionCondition_IntEdgeFromToFeature : animAnimStateTransitionCondition_IntEdgeFeature
	{
		private CInt32 _fromValue;
		private CInt32 _toValue;

		[Ordinal(2)] 
		[RED("fromValue")] 
		public CInt32 FromValue
		{
			get => GetProperty(ref _fromValue);
			set => SetProperty(ref _fromValue, value);
		}

		[Ordinal(3)] 
		[RED("toValue")] 
		public CInt32 ToValue
		{
			get => GetProperty(ref _toValue);
			set => SetProperty(ref _toValue, value);
		}
	}
}
