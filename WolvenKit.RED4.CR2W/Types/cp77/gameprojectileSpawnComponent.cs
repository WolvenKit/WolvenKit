using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSpawnComponent : entIPlacedComponent
	{
		private Vector3 _spawnOffset;
		private CArray<CName> _projectileTemplates;
		private CName _slotName;

		[Ordinal(5)] 
		[RED("spawnOffset")] 
		public Vector3 SpawnOffset
		{
			get
			{
				if (_spawnOffset == null)
				{
					_spawnOffset = (Vector3) CR2WTypeManager.Create("Vector3", "spawnOffset", cr2w, this);
				}
				return _spawnOffset;
			}
			set
			{
				if (_spawnOffset == value)
				{
					return;
				}
				_spawnOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("projectileTemplates")] 
		public CArray<CName> ProjectileTemplates
		{
			get
			{
				if (_projectileTemplates == null)
				{
					_projectileTemplates = (CArray<CName>) CR2WTypeManager.Create("array:CName", "projectileTemplates", cr2w, this);
				}
				return _projectileTemplates;
			}
			set
			{
				if (_projectileTemplates == value)
				{
					return;
				}
				_projectileTemplates = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		public gameprojectileSpawnComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
