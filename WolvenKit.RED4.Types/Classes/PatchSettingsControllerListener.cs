using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PatchSettingsControllerListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<PatchSettingsController> Ctrl
		{
			get => GetPropertyValue<CWeakHandle<PatchSettingsController>>();
			set => SetPropertyValue<CWeakHandle<PatchSettingsController>>(value);
		}

		public PatchSettingsControllerListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
