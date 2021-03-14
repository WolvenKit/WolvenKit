using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class dbgSpawner : gameObject
	{
		private TweakDBID _objectRecordId;
		private CName _appearance;
		private CBool _isActive;
		private CEnum<gameAlwaysSpawnedState> _alwaysSpawned;

		[Ordinal(40)] 
		[RED("objectRecordId")] 
		public TweakDBID ObjectRecordId
		{
			get
			{
				if (_objectRecordId == null)
				{
					_objectRecordId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "objectRecordId", cr2w, this);
				}
				return _objectRecordId;
			}
			set
			{
				if (_objectRecordId == value)
				{
					return;
				}
				_objectRecordId = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("appearance")] 
		public CName Appearance
		{
			get
			{
				if (_appearance == null)
				{
					_appearance = (CName) CR2WTypeManager.Create("CName", "appearance", cr2w, this);
				}
				return _appearance;
			}
			set
			{
				if (_appearance == value)
				{
					return;
				}
				_appearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("alwaysSpawned")] 
		public CEnum<gameAlwaysSpawnedState> AlwaysSpawned
		{
			get
			{
				if (_alwaysSpawned == null)
				{
					_alwaysSpawned = (CEnum<gameAlwaysSpawnedState>) CR2WTypeManager.Create("gameAlwaysSpawnedState", "alwaysSpawned", cr2w, this);
				}
				return _alwaysSpawned;
			}
			set
			{
				if (_alwaysSpawned == value)
				{
					return;
				}
				_alwaysSpawned = value;
				PropertySet(this);
			}
		}

		public dbgSpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
