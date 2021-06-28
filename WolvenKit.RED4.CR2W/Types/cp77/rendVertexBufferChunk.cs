using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendVertexBufferChunk : CVariable
	{
		private GpuWrapApiVertexLayoutDesc _vertexLayout;
		private CStatic<CUInt32> _byteOffsets;

		[Ordinal(0)] 
		[RED("vertexLayout")] 
		public GpuWrapApiVertexLayoutDesc VertexLayout
		{
			get => GetProperty(ref _vertexLayout);
			set => SetProperty(ref _vertexLayout, value);
		}

		[Ordinal(1)] 
		[RED("byteOffsets", 5)] 
		public CStatic<CUInt32> ByteOffsets
		{
			get => GetProperty(ref _byteOffsets);
			set => SetProperty(ref _byteOffsets, value);
		}

		public rendVertexBufferChunk(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
