using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderMultilayerMaskBlob : IRenderResourceBlob
	{
		private rendRenderMultilayerMaskBlobHeader _header;
		private serializationDeferredDataBuffer _atlasData;
		private serializationDeferredDataBuffer _tilesData;

		[Ordinal(0)] 
		[RED("header")] 
		public rendRenderMultilayerMaskBlobHeader Header
		{
			get
			{
				if (_header == null)
				{
					_header = (rendRenderMultilayerMaskBlobHeader) CR2WTypeManager.Create("rendRenderMultilayerMaskBlobHeader", "header", cr2w, this);
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
		[RED("atlasData")] 
		public serializationDeferredDataBuffer AtlasData
		{
			get
			{
				if (_atlasData == null)
				{
					_atlasData = (serializationDeferredDataBuffer) CR2WTypeManager.Create("serializationDeferredDataBuffer", "atlasData", cr2w, this);
				}
				return _atlasData;
			}
			set
			{
				if (_atlasData == value)
				{
					return;
				}
				_atlasData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tilesData")] 
		public serializationDeferredDataBuffer TilesData
		{
			get
			{
				if (_tilesData == null)
				{
					_tilesData = (serializationDeferredDataBuffer) CR2WTypeManager.Create("serializationDeferredDataBuffer", "tilesData", cr2w, this);
				}
				return _tilesData;
			}
			set
			{
				if (_tilesData == value)
				{
					return;
				}
				_tilesData = value;
				PropertySet(this);
			}
		}

		public rendRenderMultilayerMaskBlob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
