using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCookedMappinData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("journalPathHash")] 
		public CUInt32 JournalPathHash
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector3 Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("volume")] 
		public CHandle<gamemappinsIMappinVolume> Volume
		{
			get => GetPropertyValue<CHandle<gamemappinsIMappinVolume>>();
			set => SetPropertyValue<CHandle<gamemappinsIMappinVolume>>(value);
		}

		public gameCookedMappinData()
		{
			Position = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
