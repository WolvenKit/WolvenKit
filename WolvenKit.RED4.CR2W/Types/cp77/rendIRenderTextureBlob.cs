using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendIRenderTextureBlob : IRenderResourceBlob
	{
		private rendRenderTextureBlobHeader _header;
		private serializationDeferredDataBuffer _textureData;

		[Ordinal(0)] 
		[RED("header")] 
		public rendRenderTextureBlobHeader Header
		{
			get
			{
				if (_header == null)
				{
					_header = (rendRenderTextureBlobHeader) CR2WTypeManager.Create("rendRenderTextureBlobHeader", "header", cr2w, this);
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
		[RED("textureData")] 
		public serializationDeferredDataBuffer TextureData
		{
			get
			{
				if (_textureData == null)
				{
					_textureData = (serializationDeferredDataBuffer) CR2WTypeManager.Create("serializationDeferredDataBuffer", "textureData", cr2w, this);
				}
				return _textureData;
			}
			set
			{
				if (_textureData == value)
				{
					return;
				}
				_textureData = value;
				PropertySet(this);
			}
		}

		public rendIRenderTextureBlob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
