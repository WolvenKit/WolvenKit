using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsGeometryCacheArtifact : CResource
	{
		private serializationDeferredDataBuffer _buffer;
		private CArray<physicsCacheKey> _entryKeys;
		private CArray<physicsCacheEntry> _entryTable;

		[Ordinal(1)] 
		[RED("buffer")] 
		public serializationDeferredDataBuffer Buffer
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

		public physicsGeometryCacheArtifact(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
