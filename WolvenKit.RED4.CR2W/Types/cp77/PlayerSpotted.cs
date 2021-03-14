using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerSpotted : redEvent
	{
		private CBool _comesFromNPC;
		private gamePersistentID _ownerID;
		private CBool _doesSee;
		private CArray<CHandle<SecurityAreaControllerPS>> _agentAreas;

		[Ordinal(0)] 
		[RED("comesFromNPC")] 
		public CBool ComesFromNPC
		{
			get
			{
				if (_comesFromNPC == null)
				{
					_comesFromNPC = (CBool) CR2WTypeManager.Create("Bool", "comesFromNPC", cr2w, this);
				}
				return _comesFromNPC;
			}
			set
			{
				if (_comesFromNPC == value)
				{
					return;
				}
				_comesFromNPC = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ownerID")] 
		public gamePersistentID OwnerID
		{
			get
			{
				if (_ownerID == null)
				{
					_ownerID = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "ownerID", cr2w, this);
				}
				return _ownerID;
			}
			set
			{
				if (_ownerID == value)
				{
					return;
				}
				_ownerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("doesSee")] 
		public CBool DoesSee
		{
			get
			{
				if (_doesSee == null)
				{
					_doesSee = (CBool) CR2WTypeManager.Create("Bool", "doesSee", cr2w, this);
				}
				return _doesSee;
			}
			set
			{
				if (_doesSee == value)
				{
					return;
				}
				_doesSee = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("agentAreas")] 
		public CArray<CHandle<SecurityAreaControllerPS>> AgentAreas
		{
			get
			{
				if (_agentAreas == null)
				{
					_agentAreas = (CArray<CHandle<SecurityAreaControllerPS>>) CR2WTypeManager.Create("array:handle:SecurityAreaControllerPS", "agentAreas", cr2w, this);
				}
				return _agentAreas;
			}
			set
			{
				if (_agentAreas == value)
				{
					return;
				}
				_agentAreas = value;
				PropertySet(this);
			}
		}

		public PlayerSpotted(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
