using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendRenderMeshBlob : IRenderResourceBlob
	{
		private rendRenderMeshBlobHeader _header;
		private DataBuffer _renderBuffer;

		[Ordinal(0)] 
		[RED("header")] 
		public rendRenderMeshBlobHeader Header
		{
			get => GetProperty(ref _header);
			set => SetProperty(ref _header, value);
		}

		[Ordinal(1)] 
		[RED("renderBuffer")] 
		public DataBuffer RenderBuffer
		{
			get => GetProperty(ref _renderBuffer);
			set => SetProperty(ref _renderBuffer, value);
		}
	}
}
