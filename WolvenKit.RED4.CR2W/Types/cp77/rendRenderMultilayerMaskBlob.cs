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
			get => GetProperty(ref _header);
			set => SetProperty(ref _header, value);
		}

		[Ordinal(1)] 
		[RED("atlasData")] 
		public serializationDeferredDataBuffer AtlasData
		{
			get => GetProperty(ref _atlasData);
			set => SetProperty(ref _atlasData, value);
		}

		[Ordinal(2)] 
		[RED("tilesData")] 
		public serializationDeferredDataBuffer TilesData
		{
			get => GetProperty(ref _tilesData);
			set => SetProperty(ref _tilesData, value);
		}

		public rendRenderMultilayerMaskBlob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
