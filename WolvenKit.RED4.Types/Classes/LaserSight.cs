using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LaserSight : Attack_Beam
	{
		[Ordinal(0)] 
		[RED("previousTarget")] 
		public CWeakHandle<entEntity> PreviousTarget
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		public LaserSight()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
