using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entVertexAnimationMapperDestination : RedBaseClass
	{
		private CUInt32 _vertexCustomSlotIndex;

		[Ordinal(0)] 
		[RED("vertexCustomSlotIndex")] 
		public CUInt32 VertexCustomSlotIndex
		{
			get => GetProperty(ref _vertexCustomSlotIndex);
			set => SetProperty(ref _vertexCustomSlotIndex, value);
		}
	}
}
