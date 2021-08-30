using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class navLocomotionPathPointUserDataEntry : RedBaseClass
	{
		private CHandle<navLocomotionPathPointUserData> _userData;
		private CUInt32 _nextUserData;

		[Ordinal(0)] 
		[RED("userData")] 
		public CHandle<navLocomotionPathPointUserData> UserData
		{
			get => GetProperty(ref _userData);
			set => SetProperty(ref _userData, value);
		}

		[Ordinal(1)] 
		[RED("nextUserData")] 
		public CUInt32 NextUserData
		{
			get => GetProperty(ref _nextUserData);
			set => SetProperty(ref _nextUserData, value);
		}

		public navLocomotionPathPointUserDataEntry()
		{
			_nextUserData = 4294967295;
		}
	}
}
