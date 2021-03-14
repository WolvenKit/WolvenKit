using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MadnessEffector : gameEffector
	{
		private CArray<entEntityID> _squadMembers;
		private wCHandle<ScriptedPuppet> _owner;

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
		public wCHandle<ScriptedPuppet> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<ScriptedPuppet>) CR2WTypeManager.Create("whandle:ScriptedPuppet", "owner", cr2w, this);
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

		public MadnessEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
