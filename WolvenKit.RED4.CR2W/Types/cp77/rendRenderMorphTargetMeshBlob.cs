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
			get
			{
				if (_header == null)
				{
					_header = (rendRenderMorphTargetMeshBlobHeader) CR2WTypeManager.Create("rendRenderMorphTargetMeshBlobHeader", "header", cr2w, this);
				}
				return _header;
			}
			set
			{
				if (_header == value)
				{
					return;
				}
				_header = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("diffsBuffer")] 
		public DataBuffer DiffsBuffer
		{
			get
			{
				if (_diffsBuffer == null)
				{
					_diffsBuffer = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "diffsBuffer", cr2w, this);
				}
				return _diffsBuffer;
			}
			set
			{
				if (_diffsBuffer == value)
				{
					return;
				}
				_diffsBuffer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("mappingBuffer")] 
		public DataBuffer MappingBuffer
		{
			get
			{
				if (_mappingBuffer == null)
				{
					_mappingBuffer = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "mappingBuffer", cr2w, this);
				}
				return _mappingBuffer;
			}
			set
			{
				if (_mappingBuffer == value)
				{
					return;
				}
				_mappingBuffer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("textureDiffsBuffer")] 
		public serializationDeferredDataBuffer TextureDiffsBuffer
		{
			get
			{
				if (_textureDiffsBuffer == null)
				{
					_textureDiffsBuffer = (serializationDeferredDataBuffer) CR2WTypeManager.Create("serializationDeferredDataBuffer", "textureDiffsBuffer", cr2w, this);
				}
				return _textureDiffsBuffer;
			}
			set
			{
				if (_textureDiffsBuffer == value)
				{
					return;
				}
				_textureDiffsBuffer = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("baseBlob")] 
		public CHandle<IRenderResourceBlob> BaseBlob
		{
			get
			{
				if (_baseBlob == null)
				{
					_baseBlob = (CHandle<IRenderResourceBlob>) CR2WTypeManager.Create("handle:IRenderResourceBlob", "baseBlob", cr2w, this);
				}
				return _baseBlob;
			}
			set
			{
				if (_baseBlob == value)
				{
					return;
				}
				_baseBlob = value;
				PropertySet(this);
			}
		}

		public rendRenderMorphTargetMeshBlob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
