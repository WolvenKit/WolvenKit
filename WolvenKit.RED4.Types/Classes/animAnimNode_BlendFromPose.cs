using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_BlendFromPose : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("blendType")] 
		public CEnum<animEBlendTypeLBC> BlendType
		{
			get => GetPropertyValue<CEnum<animEBlendTypeLBC>>();
			set => SetPropertyValue<CEnum<animEBlendTypeLBC>>(value);
		}

		[Ordinal(14)] 
		[RED("customBlendCurve")] 
		public CLegacySingleChannelCurve<CFloat> CustomBlendCurve
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(15)] 
		[RED("mode")] 
		public CEnum<animEBlendFromPoseMode> Mode
		{
			get => GetPropertyValue<CEnum<animEBlendFromPoseMode>>();
			set => SetPropertyValue<CEnum<animEBlendFromPoseMode>>(value);
		}

		[Ordinal(16)] 
		[RED("requestedByTag")] 
		public CName RequestedByTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimNode_BlendFromPose()
		{
			Id = 4294967295;
			InputLink = new();
			BlendTime = 0.200000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
