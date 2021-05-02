using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderMeshBlob : IRenderResourceBlob
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

		public rendRenderMeshBlob(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
