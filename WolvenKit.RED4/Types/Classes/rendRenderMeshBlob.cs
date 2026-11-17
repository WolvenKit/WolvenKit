using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendRenderMeshBlob : IRenderResourceBlob
	{
		[Ordinal(0)] 
		[RED("header")] 
		public rendRenderMeshBlobHeader Header
		{
			get => GetPropertyValue<rendRenderMeshBlobHeader>();
			set => SetPropertyValue<rendRenderMeshBlobHeader>(value);
		}

		[Ordinal(1)] 
		[RED("renderBuffer")] 
		public DataBuffer RenderBuffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		public rendRenderMeshBlob()
		{
			Header = new rendRenderMeshBlobHeader();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
