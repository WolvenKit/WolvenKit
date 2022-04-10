using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ThreatPersistanceMemory : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("threats")] 
		public CArray<CWeakHandle<entEntity>> Threats
		{
			get => GetPropertyValue<CArray<CWeakHandle<entEntity>>>();
			set => SetPropertyValue<CArray<CWeakHandle<entEntity>>>(value);
		}

		[Ordinal(1)] 
		[RED("isPersistent")] 
		public CArray<CBool> IsPersistent
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}

		public ThreatPersistanceMemory()
		{
			Threats = new();
			IsPersistent = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
