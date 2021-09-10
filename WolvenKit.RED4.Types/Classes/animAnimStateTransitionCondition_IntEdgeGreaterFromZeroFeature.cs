using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimStateTransitionCondition_IntEdgeGreaterFromZeroFeature : animAnimStateTransitionCondition_IntEdgeFeature
	{
		[Ordinal(2)] 
		[RED("greaterThenValue")] 
		public CInt32 GreaterThenValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
