using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SelectorRevalutionBreak : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("reevaluationDuration")] 
		public CFloat ReevaluationDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SelectorRevalutionBreak()
		{
			ReevaluationDuration = 0.100000F;
		}
	}
}
