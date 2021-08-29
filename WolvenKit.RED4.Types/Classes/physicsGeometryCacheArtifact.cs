using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsGeometryCacheArtifact : CResource
	{
		private SerializationDeferredDataBuffer _buffer;
		private CArray<physicsCacheKey> _entryKeys;
		private CArray<physicsCacheEntry> _entryTable;

		[Ordinal(1)] 
		[RED("buffer")] 
		public SerializationDeferredDataBuffer Buffer
		{
			get => GetProperty(ref _buffer);
			set => SetProperty(ref _buffer, value);
		}

		[Ordinal(2)] 
		[RED("entryKeys")] 
		public CArray<physicsCacheKey> EntryKeys
		{
			get => GetProperty(ref _entryKeys);
			set => SetProperty(ref _entryKeys, value);
		}

		[Ordinal(3)] 
		[RED("entryTable")] 
		public CArray<physicsCacheEntry> EntryTable
		{
			get => GetProperty(ref _entryTable);
			set => SetProperty(ref _entryTable, value);
		}
	}
}
