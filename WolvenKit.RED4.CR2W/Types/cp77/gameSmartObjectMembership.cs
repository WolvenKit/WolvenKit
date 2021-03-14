using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectMembership : ISerializable
	{
		private CArray<gameSmartObjectMembershipMemberShip> _members;

		[Ordinal(0)] 
		[RED("members")] 
		public CArray<gameSmartObjectMembershipMemberShip> Members
		{
			get
			{
				if (_members == null)
				{
					_members = (CArray<gameSmartObjectMembershipMemberShip>) CR2WTypeManager.Create("array:gameSmartObjectMembershipMemberShip", "members", cr2w, this);
				}
				return _members;
			}
			set
			{
				if (_members == value)
				{
					return;
				}
				_members = value;
				PropertySet(this);
			}
		}

		public gameSmartObjectMembership(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
