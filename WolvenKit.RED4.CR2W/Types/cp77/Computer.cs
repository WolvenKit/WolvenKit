using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Computer : Terminal
	{
		private CBool _bannerUpdateActive;
		private gameDelayID _bannerUpdateID;
		private CHandle<entIPlacedComponent> _transformX;
		private CHandle<entIPlacedComponent> _transformY;
		private PlayerControlDeviceData _playerControlData;
		private CEnum<EComputerAnimationState> _currentAnimationState;

		[Ordinal(96)] 
		[RED("bannerUpdateActive")] 
		public CBool BannerUpdateActive
		{
			get => GetProperty(ref _bannerUpdateActive);
			set => SetProperty(ref _bannerUpdateActive, value);
		}

		[Ordinal(97)] 
		[RED("bannerUpdateID")] 
		public gameDelayID BannerUpdateID
		{
			get => GetProperty(ref _bannerUpdateID);
			set => SetProperty(ref _bannerUpdateID, value);
		}

		[Ordinal(98)] 
		[RED("transformX")] 
		public CHandle<entIPlacedComponent> TransformX
		{
			get => GetProperty(ref _transformX);
			set => SetProperty(ref _transformX, value);
		}

		[Ordinal(99)] 
		[RED("transformY")] 
		public CHandle<entIPlacedComponent> TransformY
		{
			get => GetProperty(ref _transformY);
			set => SetProperty(ref _transformY, value);
		}

		[Ordinal(100)] 
		[RED("playerControlData")] 
		public PlayerControlDeviceData PlayerControlData
		{
			get => GetProperty(ref _playerControlData);
			set => SetProperty(ref _playerControlData, value);
		}

		[Ordinal(101)] 
		[RED("currentAnimationState")] 
		public CEnum<EComputerAnimationState> CurrentAnimationState
		{
			get => GetProperty(ref _currentAnimationState);
			set => SetProperty(ref _currentAnimationState, value);
		}

		public Computer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
