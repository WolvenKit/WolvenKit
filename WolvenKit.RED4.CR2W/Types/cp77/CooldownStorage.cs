using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CooldownStorage : IScriptable
	{
		private PSOwnerData _owner;
		private CEnum<EBOOL> _initialized;
		private ScriptGameInstance _gameInstanceHack;
		private CArray<CHandle<CooldownPackage>> _packages;
		private CUInt32 _currentID;
		private CArray<CooldownPackageDelayIDs> _map;

		[Ordinal(0)] 
		[RED("owner")] 
		public PSOwnerData Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (PSOwnerData) CR2WTypeManager.Create("PSOwnerData", "owner", cr2w, this);
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

		[Ordinal(1)] 
		[RED("initialized")] 
		public CEnum<EBOOL> Initialized
		{
			get
			{
				if (_initialized == null)
				{
					_initialized = (CEnum<EBOOL>) CR2WTypeManager.Create("EBOOL", "initialized", cr2w, this);
				}
				return _initialized;
			}
			set
			{
				if (_initialized == value)
				{
					return;
				}
				_initialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("gameInstanceHack")] 
		public ScriptGameInstance GameInstanceHack
		{
			get
			{
				if (_gameInstanceHack == null)
				{
					_gameInstanceHack = (ScriptGameInstance) CR2WTypeManager.Create("ScriptGameInstance", "gameInstanceHack", cr2w, this);
				}
				return _gameInstanceHack;
			}
			set
			{
				if (_gameInstanceHack == value)
				{
					return;
				}
				_gameInstanceHack = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("packages")] 
		public CArray<CHandle<CooldownPackage>> Packages
		{
			get
			{
				if (_packages == null)
				{
					_packages = (CArray<CHandle<CooldownPackage>>) CR2WTypeManager.Create("array:handle:CooldownPackage", "packages", cr2w, this);
				}
				return _packages;
			}
			set
			{
				if (_packages == value)
				{
					return;
				}
				_packages = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("currentID")] 
		public CUInt32 CurrentID
		{
			get
			{
				if (_currentID == null)
				{
					_currentID = (CUInt32) CR2WTypeManager.Create("Uint32", "currentID", cr2w, this);
				}
				return _currentID;
			}
			set
			{
				if (_currentID == value)
				{
					return;
				}
				_currentID = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("map")] 
		public CArray<CooldownPackageDelayIDs> Map
		{
			get
			{
				if (_map == null)
				{
					_map = (CArray<CooldownPackageDelayIDs>) CR2WTypeManager.Create("array:CooldownPackageDelayIDs", "map", cr2w, this);
				}
				return _map;
			}
			set
			{
				if (_map == value)
				{
					return;
				}
				_map = value;
				PropertySet(this);
			}
		}

		public CooldownStorage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
