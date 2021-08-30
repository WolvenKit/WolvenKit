using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_BlendFromPose : animAnimNode_OnePoseInput
	{
		private CFloat _blendTime;
		private CEnum<animEBlendTypeLBC> _blendType;
		private CLegacySingleChannelCurve<CFloat> _customBlendCurve;
		private CEnum<animEBlendFromPoseMode> _mode;
		private CName _requestedByTag;

		[Ordinal(12)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetProperty(ref _blendTime);
			set => SetProperty(ref _blendTime, value);
		}

		[Ordinal(13)] 
		[RED("blendType")] 
		public CEnum<animEBlendTypeLBC> BlendType
		{
			get => GetProperty(ref _blendType);
			set => SetProperty(ref _blendType, value);
		}

		[Ordinal(14)] 
		[RED("customBlendCurve")] 
		public CLegacySingleChannelCurve<CFloat> CustomBlendCurve
		{
			get => GetProperty(ref _customBlendCurve);
			set => SetProperty(ref _customBlendCurve, value);
		}

		[Ordinal(15)] 
		[RED("mode")] 
		public CEnum<animEBlendFromPoseMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(16)] 
		[RED("requestedByTag")] 
		public CName RequestedByTag
		{
			get => GetProperty(ref _requestedByTag);
			set => SetProperty(ref _requestedByTag, value);
		}

		public animAnimNode_BlendFromPose()
		{
			_blendTime = 0.200000F;
		}
	}
}
