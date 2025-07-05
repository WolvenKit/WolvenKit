using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldRotatingMeshNode : worldMeshNode
	{
		[Ordinal(18)] 
		[RED("rotationAxis")] 
		public CEnum<worldRotatingMeshNodeAxis> RotationAxis
		{
			get => GetPropertyValue<CEnum<worldRotatingMeshNodeAxis>>();
			set => SetPropertyValue<CEnum<worldRotatingMeshNodeAxis>>(value);
		}

		[Ordinal(19)] 
		[RED("fullRotationTime")] 
		public CFloat FullRotationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("reverseDirection")] 
		public CBool ReverseDirection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldRotatingMeshNode()
		{
			FullRotationTime = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
