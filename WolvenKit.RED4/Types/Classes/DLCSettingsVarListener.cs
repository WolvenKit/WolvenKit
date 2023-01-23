using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DLCSettingsVarListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<DlcDescriptionController> Ctrl
		{
			get => GetPropertyValue<CWeakHandle<DlcDescriptionController>>();
			set => SetPropertyValue<CWeakHandle<DlcDescriptionController>>(value);
		}

		public DLCSettingsVarListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
