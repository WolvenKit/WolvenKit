using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileSetUpEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("weapon")] 
		public CWeakHandle<gameObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("trajectoryParams")] 
		public CHandle<gameprojectileTrajectoryParams> TrajectoryParams
		{
			get => GetPropertyValue<CHandle<gameprojectileTrajectoryParams>>();
			set => SetPropertyValue<CHandle<gameprojectileTrajectoryParams>>(value);
		}

		[Ordinal(3)] 
		[RED("lerpMultiplier")] 
		public CFloat LerpMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameprojectileSetUpEvent()
		{
			LerpMultiplier = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
