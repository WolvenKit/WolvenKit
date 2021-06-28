using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshLocalMaterialHeader : CVariable
	{
		private CUInt32 _offset;
		private CUInt32 _size;

		[Ordinal(0)] 
		[RED("offset")] 
		public CUInt32 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(1)] 
		[RED("size")] 
		public CUInt32 Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}

		public meshLocalMaterialHeader(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
