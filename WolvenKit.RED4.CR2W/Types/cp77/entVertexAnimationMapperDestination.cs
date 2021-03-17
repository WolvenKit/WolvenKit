using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entVertexAnimationMapperDestination : CVariable
	{
		private CUInt32 _vertexCustomSlotIndex;

		[Ordinal(0)] 
		[RED("vertexCustomSlotIndex")] 
		public CUInt32 VertexCustomSlotIndex
		{
			get => GetProperty(ref _vertexCustomSlotIndex);
			set => SetProperty(ref _vertexCustomSlotIndex, value);
		}

		public entVertexAnimationMapperDestination(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
