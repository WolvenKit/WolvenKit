using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimStateTransitionInterpolator_Blend : animIAnimStateTransitionInterpolator
	{
		private CEnum<animAnimStateInterpolationType> _interpolationType;

		[Ordinal(0)] 
		[RED("interpolationType")] 
		public CEnum<animAnimStateInterpolationType> InterpolationType
		{
			get => GetProperty(ref _interpolationType);
			set => SetProperty(ref _interpolationType, value);
		}
	}
}
