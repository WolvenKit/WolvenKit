using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChatterKeyValuePair : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Key")] 
		public CRUID Key
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		[Ordinal(1)] 
		[RED("Value")] 
		public CWeakHandle<ChatterLineLogicController> Value
		{
			get => GetPropertyValue<CWeakHandle<ChatterLineLogicController>>();
			set => SetPropertyValue<CWeakHandle<ChatterLineLogicController>>(value);
		}

		[Ordinal(2)] 
		[RED("Owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public ChatterKeyValuePair()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
