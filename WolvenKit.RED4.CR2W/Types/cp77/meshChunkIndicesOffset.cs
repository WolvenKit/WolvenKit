using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshChunkIndicesOffset : CVariable
	{
		private CUInt32 _start;
		private CUInt32 _count;
		private CUInt8 _boneIndex;

		[Ordinal(0)] 
		[RED("start")] 
		public CUInt32 Start
		{
			get => GetProperty(ref _start);
			set => SetProperty(ref _start, value);
		}

		[Ordinal(1)] 
		[RED("count")] 
		public CUInt32 Count
		{
			get => GetProperty(ref _count);
			set => SetProperty(ref _count, value);
		}

		[Ordinal(2)] 
		[RED("boneIndex")] 
		public CUInt8 BoneIndex
		{
			get => GetProperty(ref _boneIndex);
			set => SetProperty(ref _boneIndex, value);
		}

		public meshChunkIndicesOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
