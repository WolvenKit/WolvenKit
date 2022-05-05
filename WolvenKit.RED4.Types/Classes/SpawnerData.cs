using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SpawnerData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("spawnerID")] 
		public entEntityID SpawnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("entryNames")] 
		public CArray<CName> EntryNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public SpawnerData()
		{
			SpawnerID = new();
			EntryNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
