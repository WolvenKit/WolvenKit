using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entRagdollImpactEvent : redEvent
	{
		private CWeakHandle<entEntity> _otherEntity;
		private CBool _triggeredSimulation;
		private CArray<entRagdollImpactPointData> _impactPoints;

		[Ordinal(0)] 
		[RED("otherEntity")] 
		public CWeakHandle<entEntity> OtherEntity
		{
			get => GetProperty(ref _otherEntity);
			set => SetProperty(ref _otherEntity, value);
		}

		[Ordinal(1)] 
		[RED("triggeredSimulation")] 
		public CBool TriggeredSimulation
		{
			get => GetProperty(ref _triggeredSimulation);
			set => SetProperty(ref _triggeredSimulation, value);
		}

		[Ordinal(2)] 
		[RED("impactPoints")] 
		public CArray<entRagdollImpactPointData> ImpactPoints
		{
			get => GetProperty(ref _impactPoints);
			set => SetProperty(ref _impactPoints, value);
		}
	}
}
