using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animPoseCorrectionParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("poseCorrectionGroup")] 
		public animPoseCorrectionGroup PoseCorrectionGroup
		{
			get => GetPropertyValue<animPoseCorrectionGroup>();
			set => SetPropertyValue<animPoseCorrectionGroup>(value);
		}

		[Ordinal(1)] 
		[RED("blendDuration")] 
		public CFloat BlendDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animPoseCorrectionParams()
		{
			PoseCorrectionGroup = new() { PoseCorrections = new(0) };
			BlendDuration = 0.200000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
