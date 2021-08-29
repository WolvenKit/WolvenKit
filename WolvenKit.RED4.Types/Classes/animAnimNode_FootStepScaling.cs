using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_FootStepScaling : animAnimNode_OnePoseInput
	{
		private animTransformIndex _hipsIndex;
		private animTransformIndex _leftFootIKIndex;
		private animTransformIndex _rightFootIKIndex;
		private animFloatLink _inputSpeed;
		private animFloatLink _weight;
		private animfssBodyOfflineParams _params;

		[Ordinal(12)] 
		[RED("hipsIndex")] 
		public animTransformIndex HipsIndex
		{
			get => GetProperty(ref _hipsIndex);
			set => SetProperty(ref _hipsIndex, value);
		}

		[Ordinal(13)] 
		[RED("leftFootIKIndex")] 
		public animTransformIndex LeftFootIKIndex
		{
			get => GetProperty(ref _leftFootIKIndex);
			set => SetProperty(ref _leftFootIKIndex, value);
		}

		[Ordinal(14)] 
		[RED("rightFootIKIndex")] 
		public animTransformIndex RightFootIKIndex
		{
			get => GetProperty(ref _rightFootIKIndex);
			set => SetProperty(ref _rightFootIKIndex, value);
		}

		[Ordinal(15)] 
		[RED("inputSpeed")] 
		public animFloatLink InputSpeed
		{
			get => GetProperty(ref _inputSpeed);
			set => SetProperty(ref _inputSpeed, value);
		}

		[Ordinal(16)] 
		[RED("weight")] 
		public animFloatLink Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(17)] 
		[RED("Params")] 
		public animfssBodyOfflineParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
