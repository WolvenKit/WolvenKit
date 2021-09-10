using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Computer : Terminal
	{
		[Ordinal(100)] 
		[RED("bannerUpdateActive")] 
		public CBool BannerUpdateActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(101)] 
		[RED("bannerUpdateID")] 
		public gameDelayID BannerUpdateID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(102)] 
		[RED("transformX")] 
		public CHandle<entIPlacedComponent> TransformX
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(103)] 
		[RED("transformY")] 
		public CHandle<entIPlacedComponent> TransformY
		{
			get => GetPropertyValue<CHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(104)] 
		[RED("playerControlData")] 
		public PlayerControlDeviceData PlayerControlData
		{
			get => GetPropertyValue<PlayerControlDeviceData>();
			set => SetPropertyValue<PlayerControlDeviceData>(value);
		}

		[Ordinal(105)] 
		[RED("currentAnimationState")] 
		public CEnum<EComputerAnimationState> CurrentAnimationState
		{
			get => GetPropertyValue<CEnum<EComputerAnimationState>>();
			set => SetPropertyValue<CEnum<EComputerAnimationState>>(value);
		}

		public Computer()
		{
			ControllerTypeName = "ComputerController";
			BannerUpdateID = new();
			PlayerControlData = new();
		}
	}
}
