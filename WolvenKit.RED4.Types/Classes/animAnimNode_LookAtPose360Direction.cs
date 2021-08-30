using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_LookAtPose360Direction : animAnimNode_FloatValue
	{
		private CFloat _angleOffset;
		private CFloat _defaultValue;
		private CBool _negateOutput;

		[Ordinal(11)] 
		[RED("angleOffset")] 
		public CFloat AngleOffset
		{
			get => GetProperty(ref _angleOffset);
			set => SetProperty(ref _angleOffset, value);
		}

		[Ordinal(12)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}

		[Ordinal(13)] 
		[RED("negateOutput")] 
		public CBool NegateOutput
		{
			get => GetProperty(ref _negateOutput);
			set => SetProperty(ref _negateOutput, value);
		}

		public animAnimNode_LookAtPose360Direction()
		{
			_angleOffset = -90.000000F;
		}
	}
}
