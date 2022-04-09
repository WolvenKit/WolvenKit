using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RoyceLaserSight : Attack_Beam
	{
		[Ordinal(0)] 
		[RED("previousTarget")] 
		public CWeakHandle<entEntity> PreviousTarget
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		public RoyceLaserSight()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
