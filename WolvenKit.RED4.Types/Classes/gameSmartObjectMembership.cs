using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSmartObjectMembership : ISerializable
	{
		[Ordinal(0)] 
		[RED("members")] 
		public CArray<gameSmartObjectMembershipMemberShip> Members
		{
			get => GetPropertyValue<CArray<gameSmartObjectMembershipMemberShip>>();
			set => SetPropertyValue<CArray<gameSmartObjectMembershipMemberShip>>(value);
		}

		public gameSmartObjectMembership()
		{
			Members = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
