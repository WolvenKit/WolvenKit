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
			get
			{
				if (_bannerUpdateActive == null)
				{
					_bannerUpdateActive = (CBool) CR2WTypeManager.Create("Bool", "bannerUpdateActive", cr2w, this);
				}
				return _bannerUpdateActive;
			}
			set
			{
				if (_bannerUpdateActive == value)
				{
					return;
				}
				_bannerUpdateActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("bannerUpdateID")] 
		public gameDelayID BannerUpdateID
		{
			get
			{
				if (_bannerUpdateID == null)
				{
					_bannerUpdateID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "bannerUpdateID", cr2w, this);
				}
				return _bannerUpdateID;
			}
			set
			{
				if (_bannerUpdateID == value)
				{
					return;
				}
				_bannerUpdateID = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("transformX")] 
		public CHandle<entIPlacedComponent> TransformX
		{
			get
			{
				if (_transformX == null)
				{
					_transformX = (CHandle<entIPlacedComponent>) CR2WTypeManager.Create("handle:entIPlacedComponent", "transformX", cr2w, this);
				}
				return _transformX;
			}
			set
			{
				if (_transformX == value)
				{
					return;
				}
				_transformX = value;
				PropertySet(this);
			}
		}

		[Ordinal(99)] 
		[RED("transformY")] 
		public CHandle<entIPlacedComponent> TransformY
		{
			get
			{
				if (_transformY == null)
				{
					_transformY = (CHandle<entIPlacedComponent>) CR2WTypeManager.Create("handle:entIPlacedComponent", "transformY", cr2w, this);
				}
				return _transformY;
			}
			set
			{
				if (_transformY == value)
				{
					return;
				}
				_transformY = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("playerControlData")] 
		public PlayerControlDeviceData PlayerControlData
		{
			get
			{
				if (_playerControlData == null)
				{
					_playerControlData = (PlayerControlDeviceData) CR2WTypeManager.Create("PlayerControlDeviceData", "playerControlData", cr2w, this);
				}
				return _playerControlData;
			}
			set
			{
				if (_playerControlData == value)
				{
					return;
				}
				_playerControlData = value;
				PropertySet(this);
			}
		}

		[Ordinal(101)] 
		[RED("currentAnimationState")] 
		public CEnum<EComputerAnimationState> CurrentAnimationState
		{
			get
			{
				if (_currentAnimationState == null)
				{
					_currentAnimationState = (CEnum<EComputerAnimationState>) CR2WTypeManager.Create("EComputerAnimationState", "currentAnimationState", cr2w, this);
				}
				return _currentAnimationState;
			}
			set
			{
				if (_currentAnimationState == value)
				{
					return;
				}
				_currentAnimationState = value;
				PropertySet(this);
			}
		}

		public Computer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
