using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CooldownStorage : IScriptable
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public PSOwnerData Owner
		{
			get => GetPropertyValue<PSOwnerData>();
			set => SetPropertyValue<PSOwnerData>(value);
		}

		[Ordinal(1)] 
		[RED("initialized")] 
		public CEnum<EBOOL> Initialized
		{
			get => GetPropertyValue<CEnum<EBOOL>>();
			set => SetPropertyValue<CEnum<EBOOL>>(value);
		}

		[Ordinal(2)] 
		[RED("gameInstanceHack")] 
		public ScriptGameInstance GameInstanceHack
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(3)] 
		[RED("packages")] 
		public CArray<CHandle<CooldownPackage>> Packages
		{
			get => GetPropertyValue<CArray<CHandle<CooldownPackage>>>();
			set => SetPropertyValue<CArray<CHandle<CooldownPackage>>>(value);
		}

		[Ordinal(4)] 
		[RED("currentID")] 
		public CUInt32 CurrentID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("map")] 
		public CArray<CooldownPackageDelayIDs> Map
		{
			get => GetPropertyValue<CArray<CooldownPackageDelayIDs>>();
			set => SetPropertyValue<CArray<CooldownPackageDelayIDs>>(value);
		}

		public CooldownStorage()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
