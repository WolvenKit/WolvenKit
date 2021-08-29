using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTransformAnimation_Position_InitialPosition : gameTransformAnimation_Position
	{
		private Vector3 _offset;
		private CBool _offsetInWorldSpace;

		[Ordinal(0)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(1)] 
		[RED("offsetInWorldSpace")] 
		public CBool OffsetInWorldSpace
		{
			get => GetProperty(ref _offsetInWorldSpace);
			set => SetProperty(ref _offsetInWorldSpace, value);
		}
	}
}
