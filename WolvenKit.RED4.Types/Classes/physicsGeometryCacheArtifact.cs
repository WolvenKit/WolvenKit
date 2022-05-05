using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsGeometryCacheArtifact : CResource
	{
		[Ordinal(1)] 
		[RED("buffer")] 
		public SerializationDeferredDataBuffer Buffer
		{
			get => GetPropertyValue<SerializationDeferredDataBuffer>();
			set => SetPropertyValue<SerializationDeferredDataBuffer>(value);
		}

		[Ordinal(2)] 
		[RED("entryKeys")] 
		public CArray<physicsCacheKey> EntryKeys
		{
			get => GetPropertyValue<CArray<physicsCacheKey>>();
			set => SetPropertyValue<CArray<physicsCacheKey>>(value);
		}

		[Ordinal(3)] 
		[RED("entryTable")] 
		public CArray<physicsCacheEntry> EntryTable
		{
			get => GetPropertyValue<CArray<physicsCacheEntry>>();
			set => SetPropertyValue<CArray<physicsCacheEntry>>(value);
		}

		public physicsGeometryCacheArtifact()
		{
			EntryKeys = new();
			EntryTable = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
