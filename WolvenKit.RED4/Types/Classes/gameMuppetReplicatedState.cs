using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetReplicatedState : netIEntityState
	{
		[Ordinal(2)] 
		[RED("state")] 
		public gameMuppetState State
		{
			get => GetPropertyValue<gameMuppetState>();
			set => SetPropertyValue<gameMuppetState>(value);
		}

		[Ordinal(3)] 
		[RED("initialOrientation")] 
		public EulerAngles InitialOrientation
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		[Ordinal(4)] 
		[RED("initialLocation")] 
		public Vector3 InitialLocation
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(5)] 
		[RED("health")] 
		public CFloat Health
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("armor")] 
		public CFloat Armor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameMuppetReplicatedState()
		{
			State = new gameMuppetState();
			InitialOrientation = new EulerAngles();
			InitialLocation = new Vector3();
			Health = -1.000000F;
			Armor = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
