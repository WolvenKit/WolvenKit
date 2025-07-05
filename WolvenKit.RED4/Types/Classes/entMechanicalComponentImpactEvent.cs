using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entMechanicalComponentImpactEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("otherEntity")] 
		public CWeakHandle<entEntity> OtherEntity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(1)] 
		[RED("impactPoints")] 
		public CArray<entImpactPointData> ImpactPoints
		{
			get => GetPropertyValue<CArray<entImpactPointData>>();
			set => SetPropertyValue<CArray<entImpactPointData>>(value);
		}

		public entMechanicalComponentImpactEvent()
		{
			ImpactPoints = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
