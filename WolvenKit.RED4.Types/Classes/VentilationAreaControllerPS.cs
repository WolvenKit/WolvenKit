using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VentilationAreaControllerPS : MasterControllerPS
	{
		[Ordinal(105)] 
		[RED("ventilationAreaSetup")] 
		public VentilationAreaSetup VentilationAreaSetup
		{
			get => GetPropertyValue<VentilationAreaSetup>();
			set => SetPropertyValue<VentilationAreaSetup>(value);
		}

		[Ordinal(106)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VentilationAreaControllerPS()
		{
			DeviceName = "VentilationArea";
			TweakDBRecord = new() { Value = 102529162810 };
			TweakDBDescriptionRecord = new() { Value = 153160213641 };
			VentilationAreaSetup = new() { ActionName = "Activate" };
		}
	}
}
