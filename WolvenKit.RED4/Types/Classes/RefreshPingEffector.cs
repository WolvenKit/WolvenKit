using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RefreshPingEffector : gameEffector
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

		public RefreshPingEffector()
		{
			SquadMembers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
