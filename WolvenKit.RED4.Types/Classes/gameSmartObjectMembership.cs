using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSmartObjectMembership : ISerializable
	{
		private CArray<gameSmartObjectMembershipMemberShip> _members;

		[Ordinal(0)] 
		[RED("members")] 
		public CArray<gameSmartObjectMembershipMemberShip> Members
		{
			get => GetProperty(ref _members);
			set => SetProperty(ref _members, value);
		}
	}
}
