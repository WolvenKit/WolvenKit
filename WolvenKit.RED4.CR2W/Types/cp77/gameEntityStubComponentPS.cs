using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEntityStubComponentPS : gameComponentPS
	{
		private Vector3 _entityLocalPosition;
		private Quaternion _entityLocalRotation;
		private gameCommunityID _spawnerId;
		private CName _ownerCommunityEntryName;
		private CName _selectedAppearanceName;

		[Ordinal(0)] 
		[RED("entityLocalPosition")] 
		public Vector3 EntityLocalPosition
		{
			get
			{
				if (_entityLocalPosition == null)
				{
					_entityLocalPosition = (Vector3) CR2WTypeManager.Create("Vector3", "entityLocalPosition", cr2w, this);
				}
				return _entityLocalPosition;
			}
			set
			{
				if (_entityLocalPosition == value)
				{
					return;
				}
				_entityLocalPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entityLocalRotation")] 
		public Quaternion EntityLocalRotation
		{
			get
			{
				if (_entityLocalRotation == null)
				{
					_entityLocalRotation = (Quaternion) CR2WTypeManager.Create("Quaternion", "entityLocalRotation", cr2w, this);
				}
				return _entityLocalRotation;
			}
			set
			{
				if (_entityLocalRotation == value)
				{
					return;
				}
				_entityLocalRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("spawnerId")] 
		public gameCommunityID SpawnerId
		{
			get
			{
				if (_spawnerId == null)
				{
					_spawnerId = (gameCommunityID) CR2WTypeManager.Create("gameCommunityID", "spawnerId", cr2w, this);
				}
				return _spawnerId;
			}
			set
			{
				if (_spawnerId == value)
				{
					return;
				}
				_spawnerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ownerCommunityEntryName")] 
		public CName OwnerCommunityEntryName
		{
			get
			{
				if (_ownerCommunityEntryName == null)
				{
					_ownerCommunityEntryName = (CName) CR2WTypeManager.Create("CName", "ownerCommunityEntryName", cr2w, this);
				}
				return _ownerCommunityEntryName;
			}
			set
			{
				if (_ownerCommunityEntryName == value)
				{
					return;
				}
				_ownerCommunityEntryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("selectedAppearanceName")] 
		public CName SelectedAppearanceName
		{
			get
			{
				if (_selectedAppearanceName == null)
				{
					_selectedAppearanceName = (CName) CR2WTypeManager.Create("CName", "selectedAppearanceName", cr2w, this);
				}
				return _selectedAppearanceName;
			}
			set
			{
				if (_selectedAppearanceName == value)
				{
					return;
				}
				_selectedAppearanceName = value;
				PropertySet(this);
			}
		}

		public gameEntityStubComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
