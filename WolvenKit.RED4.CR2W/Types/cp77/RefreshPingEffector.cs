using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RefreshPingEffector : gameEffector
	{
		private CArray<entEntityID> _squadMembers;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("squadMembers")] 
		public CArray<entEntityID> SquadMembers
		{
			get
			{
				if (_squadMembers == null)
				{
					_squadMembers = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "squadMembers", cr2w, this);
				}
				return _squadMembers;
			}
			set
			{
				if (_squadMembers == value)
				{
					return;
				}
				_squadMembers = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		public RefreshPingEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
