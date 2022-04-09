using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimStateTransitionInterpolator_Blend : animIAnimStateTransitionInterpolator
	{
		[Ordinal(0)] 
		[RED("interpolationType")] 
		public CEnum<animAnimStateInterpolationType> InterpolationType
		{
			get => GetPropertyValue<CEnum<animAnimStateInterpolationType>>();
			set => SetPropertyValue<CEnum<animAnimStateInterpolationType>>(value);
		}

		public animAnimStateTransitionInterpolator_Blend()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
