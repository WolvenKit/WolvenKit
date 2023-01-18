using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DropdownItemClickedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<IScriptable> Owner
		{
			get => GetPropertyValue<CWeakHandle<IScriptable>>();
			set => SetPropertyValue<CWeakHandle<IScriptable>>(value);
		}

		[Ordinal(1)] 
		[RED("triggerButton")] 
		public CWeakHandle<DropdownButtonController> TriggerButton
		{
			get => GetPropertyValue<CWeakHandle<DropdownButtonController>>();
			set => SetPropertyValue<CWeakHandle<DropdownButtonController>>(value);
		}

		[Ordinal(2)] 
		[RED("identifier")] 
		public CVariant Identifier
		{
			get => GetPropertyValue<CVariant>();
			set => SetPropertyValue<CVariant>(value);
		}

		public DropdownItemClickedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
