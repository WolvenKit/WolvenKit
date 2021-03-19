using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderMorphTargetMeshBlob : IRenderResourceBlob
	{
		private rendRenderMorphTargetMeshBlobHeader _header;
		private DataBuffer _diffsBuffer;
		private DataBuffer _mappingBuffer;
		private serializationDeferredDataBuffer _textureDiffsBuffer;
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
		public serializationDeferredDataBuffer TextureDiffsBuffer
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

		public rendRenderMorphTargetMeshBlob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
