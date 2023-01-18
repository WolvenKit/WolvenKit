using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entRagdollImpactEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("otherEntity")] 
		public CWeakHandle<entEntity> OtherEntity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(1)] 
		[RED("triggeredSimulation")] 
		public CBool TriggeredSimulation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("impactPoints")] 
		public CArray<entRagdollImpactPointData> ImpactPoints
		{
			get => GetPropertyValue<CArray<entRagdollImpactPointData>>();
			set => SetPropertyValue<CArray<entRagdollImpactPointData>>(value);
		}

		public entRagdollImpactEvent()
		{
			ImpactPoints = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
