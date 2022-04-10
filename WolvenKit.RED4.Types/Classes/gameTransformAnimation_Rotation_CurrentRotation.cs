using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTransformAnimation_Rotation_CurrentRotation : gameTransformAnimation_Rotation
	{
		[Ordinal(0)] 
		[RED("offset")] 
		public Quaternion Offset
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public gameTransformAnimation_Rotation_CurrentRotation()
		{
			Offset = new() { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
