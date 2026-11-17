using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VentilationAreaControllerPS : MasterControllerPS
	{
		[Ordinal(108)] 
		[RED("ventilationAreaSetup")] 
		public VentilationAreaSetup VentilationAreaSetup
		{
			get => GetPropertyValue<VentilationAreaSetup>();
			set => SetPropertyValue<VentilationAreaSetup>(value);
		}

		[Ordinal(109)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VentilationAreaControllerPS()
		{
			DeviceName = "VentilationArea";
			TweakDBRecord = "Devices.VentilationArea";
			TweakDBDescriptionRecord = "device_descriptions.VentilationArea";
			VentilationAreaSetup = new VentilationAreaSetup();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
