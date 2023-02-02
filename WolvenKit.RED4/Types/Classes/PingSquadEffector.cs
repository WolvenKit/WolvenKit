using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PingSquadEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("squadMembers")] 
		public CArray<entEntityID> SquadMembers
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("oldSquadAttitude")] 
		public CHandle<gameAttitudeAgent> OldSquadAttitude
		{
			get => GetPropertyValue<CHandle<gameAttitudeAgent>>();
			set => SetPropertyValue<CHandle<gameAttitudeAgent>>(value);
		}

		[Ordinal(3)] 
		[RED("quickhackLevel")] 
		public CFloat QuickhackLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CHandle<FocusForcedHighlightData> Data
		{
			get => GetPropertyValue<CHandle<FocusForcedHighlightData>>();
			set => SetPropertyValue<CHandle<FocusForcedHighlightData>>(value);
		}

		[Ordinal(5)] 
		[RED("squadName")] 
		public CName SquadName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public PingSquadEffector()
		{
			SquadMembers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
