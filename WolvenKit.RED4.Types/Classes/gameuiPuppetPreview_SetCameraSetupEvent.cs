using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPuppetPreview_SetCameraSetupEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("setupIndex")] 
		public CUInt32 SetupIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("delayed")] 
		public CBool Delayed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiPuppetPreview_SetCameraSetupEvent()
		{
			SetupIndex = 4294967295;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
