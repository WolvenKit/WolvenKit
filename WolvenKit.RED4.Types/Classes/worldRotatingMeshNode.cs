using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRotatingMeshNode : worldMeshNode
	{
		private CEnum<worldRotatingMeshNodeAxis> _rotationAxis;
		private CFloat _fullRotationTime;
		private CBool _reverseDirection;

		[Ordinal(15)] 
		[RED("rotationAxis")] 
		public CEnum<worldRotatingMeshNodeAxis> RotationAxis
		{
			get => GetProperty(ref _rotationAxis);
			set => SetProperty(ref _rotationAxis, value);
		}

		[Ordinal(16)] 
		[RED("fullRotationTime")] 
		public CFloat FullRotationTime
		{
			get => GetProperty(ref _fullRotationTime);
			set => SetProperty(ref _fullRotationTime, value);
		}

		[Ordinal(17)] 
		[RED("reverseDirection")] 
		public CBool ReverseDirection
		{
			get => GetProperty(ref _reverseDirection);
			set => SetProperty(ref _reverseDirection, value);
		}
	}
}
