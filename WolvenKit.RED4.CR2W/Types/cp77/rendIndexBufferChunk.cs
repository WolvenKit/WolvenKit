using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendIndexBufferChunk : CVariable
	{
		private CEnum<GpuWrapApieIndexBufferChunkType> _pe;
		private CUInt32 _teOffset;

		[Ordinal(0)] 
		[RED("pe")] 
		public CEnum<GpuWrapApieIndexBufferChunkType> Pe
		{
			get => GetProperty(ref _pe);
			set => SetProperty(ref _pe, value);
		}

		[Ordinal(1)] 
		[RED("teOffset")] 
		public CUInt32 TeOffset
		{
			get => GetProperty(ref _teOffset);
			set => SetProperty(ref _teOffset, value);
		}

		public rendIndexBufferChunk(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
