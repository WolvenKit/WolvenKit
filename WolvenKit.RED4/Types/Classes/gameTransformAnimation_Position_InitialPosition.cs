using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTransformAnimation_Position_InitialPosition : gameTransformAnimation_Position
	{
		[Ordinal(0)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("offsetInWorldSpace")] 
		public CBool OffsetInWorldSpace
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameTransformAnimation_Position_InitialPosition()
		{
			Offset = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
