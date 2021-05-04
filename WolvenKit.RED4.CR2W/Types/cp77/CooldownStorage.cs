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
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("initialized")] 
		public CEnum<EBOOL> Initialized
		{
			get => GetProperty(ref _initialized);
			set => SetProperty(ref _initialized, value);
		}

		[Ordinal(2)] 
		[RED("gameInstanceHack")] 
		public ScriptGameInstance GameInstanceHack
		{
			get => GetProperty(ref _gameInstanceHack);
			set => SetProperty(ref _gameInstanceHack, value);
		}

		[Ordinal(3)] 
		[RED("packages")] 
		public CArray<CHandle<CooldownPackage>> Packages
		{
			get => GetProperty(ref _packages);
			set => SetProperty(ref _packages, value);
		}

		[Ordinal(4)] 
		[RED("currentID")] 
		public CUInt32 CurrentID
		{
			get => GetProperty(ref _currentID);
			set => SetProperty(ref _currentID, value);
		}

		[Ordinal(5)] 
		[RED("map")] 
		public CArray<CooldownPackageDelayIDs> Map
		{
			get => GetProperty(ref _map);
			set => SetProperty(ref _map, value);
		}

		public CooldownStorage(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
