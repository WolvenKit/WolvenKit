using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTransformAnimation_Rotation_LocalRotation : gameTransformAnimation_Rotation
	{
		[Ordinal(0)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public gameTransformAnimation_Rotation_LocalRotation()
		{
			Rotation = new() { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
