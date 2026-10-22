using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_LookAtPose360Direction : animAnimNode_FloatValue
	{
		[Ordinal(1)] 
		[RED("angleOffset")] 
		public CFloat AngleOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("negateOutput")] 
		public CBool NegateOutput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_LookAtPose360Direction()
		{
			Id = uint.MaxValue;
			AngleOffset = -90.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
