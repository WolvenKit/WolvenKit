using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendRenderMorphTargetMeshBlob : IRenderResourceBlob
	{
		private rendRenderMorphTargetMeshBlobHeader _header;
		private DataBuffer _diffsBuffer;
		private DataBuffer _mappingBuffer;
		private SerializationDeferredDataBuffer _textureDiffsBuffer;
		private CHandle<IRenderResourceBlob> _baseBlob;

		[Ordinal(0)] 
		[RED("header")] 
		public rendRenderMorphTargetMeshBlobHeader Header
		{
			get => GetProperty(ref _header);
			set => SetProperty(ref _header, value);
		}

		[Ordinal(1)] 
		[RED("diffsBuffer")] 
		public DataBuffer DiffsBuffer
		{
			get => GetProperty(ref _diffsBuffer);
			set => SetProperty(ref _diffsBuffer, value);
		}

		[Ordinal(2)] 
		[RED("mappingBuffer")] 
		public DataBuffer MappingBuffer
		{
			get => GetProperty(ref _mappingBuffer);
			set => SetProperty(ref _mappingBuffer, value);
		}

		[Ordinal(3)] 
		[RED("textureDiffsBuffer")] 
		public SerializationDeferredDataBuffer TextureDiffsBuffer
		{
			get => GetProperty(ref _textureDiffsBuffer);
			set => SetProperty(ref _textureDiffsBuffer, value);
		}

		[Ordinal(4)] 
		[RED("baseBlob")] 
		public CHandle<IRenderResourceBlob> BaseBlob
		{
			get => GetProperty(ref _baseBlob);
			set => SetProperty(ref _baseBlob, value);
		}
	}
}
