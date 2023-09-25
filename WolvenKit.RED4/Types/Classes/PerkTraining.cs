using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerkTraining : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("progressBarHeaderText")] 
		public CString ProgressBarHeaderText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(99)] 
		[RED("progressBarBottomText")] 
		public CString ProgressBarBottomText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(100)] 
		[RED("pulsingEndSoundName")] 
		public CName PulsingEndSoundName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(101)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_PerkDeviceData> AnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_PerkDeviceData>>();
			set => SetPropertyValue<CHandle<AnimFeature_PerkDeviceData>>(value);
		}

		[Ordinal(102)] 
		[RED("uiSlots")] 
		public CHandle<entSlotComponent> UiSlots
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		public PerkTraining()
		{
			ControllerTypeName = "PerkTrainingController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
