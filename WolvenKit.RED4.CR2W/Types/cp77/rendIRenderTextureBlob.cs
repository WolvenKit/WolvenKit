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
			get => GetProperty(ref _header);
			set => SetProperty(ref _header, value);
		}

		[Ordinal(1)] 
		[RED("textureData")] 
		public serializationDeferredDataBuffer TextureData
		{
			get => GetProperty(ref _textureData);
			set => SetProperty(ref _textureData, value);
		}

		public rendIRenderTextureBlob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
