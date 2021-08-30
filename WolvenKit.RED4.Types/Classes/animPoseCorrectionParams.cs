using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animPoseCorrectionParams : RedBaseClass
	{
		private animPoseCorrectionGroup _poseCorrectionGroup;
		private CFloat _blendDuration;

		[Ordinal(0)] 
		[RED("poseCorrectionGroup")] 
		public animPoseCorrectionGroup PoseCorrectionGroup
		{
			get => GetProperty(ref _poseCorrectionGroup);
			set => SetProperty(ref _poseCorrectionGroup, value);
		}

		[Ordinal(1)] 
		[RED("blendDuration")] 
		public CFloat BlendDuration
		{
			get => GetProperty(ref _blendDuration);
			set => SetProperty(ref _blendDuration, value);
		}

		public animPoseCorrectionParams()
		{
			_blendDuration = 0.200000F;
		}
	}
}
