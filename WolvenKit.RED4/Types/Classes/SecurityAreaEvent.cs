using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityAreaEvent : ActionBool
	{
		[Ordinal(38)] 
		[RED("securityAreaData")] 
		public SecurityAreaData SecurityAreaData
		{
			get => GetPropertyValue<SecurityAreaData>();
			set => SetPropertyValue<SecurityAreaData>(value);
		}

		[Ordinal(39)] 
		[RED("whoBreached")] 
		public CWeakHandle<gameObject> WhoBreached
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public SecurityAreaEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
