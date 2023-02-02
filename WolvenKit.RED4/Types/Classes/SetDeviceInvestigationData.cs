using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetDeviceInvestigationData : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("ownerPuppet")] 
		public CWeakHandle<ScriptedPuppet> OwnerPuppet
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("listener")] 
		public CWeakHandle<gameObject> Listener
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public SetDeviceInvestigationData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
