using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class navLocomotionPathPointInfo : RedBaseClass
	{
		private navSerializableSplineProgression _point;
		private CUInt32 _userDataIndex;

		[Ordinal(0)] 
		[RED("point")] 
		public navSerializableSplineProgression Point
		{
			get => GetProperty(ref _point);
			set => SetProperty(ref _point, value);
		}

		[Ordinal(1)] 
		[RED("userDataIndex")] 
		public CUInt32 UserDataIndex
		{
			get => GetProperty(ref _userDataIndex);
			set => SetProperty(ref _userDataIndex, value);
		}

		public navLocomotionPathPointInfo()
		{
			_userDataIndex = 4294967295;
		}
	}
}
