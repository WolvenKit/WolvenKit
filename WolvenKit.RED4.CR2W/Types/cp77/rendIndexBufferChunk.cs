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
			get
			{
				if (_pe == null)
				{
					_pe = (CEnum<GpuWrapApieIndexBufferChunkType>) CR2WTypeManager.Create("GpuWrapApieIndexBufferChunkType", "pe", cr2w, this);
				}
				return _pe;
			}
			set
			{
				if (_pe == value)
				{
					return;
				}
				_pe = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("teOffset")] 
		public CUInt32 TeOffset
		{
			get
			{
				if (_teOffset == null)
				{
					_teOffset = (CUInt32) CR2WTypeManager.Create("Uint32", "teOffset", cr2w, this);
				}
				return _teOffset;
			}
			set
			{
				if (_teOffset == value)
				{
					return;
				}
				_teOffset = value;
				PropertySet(this);
			}
		}

		public rendIndexBufferChunk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
