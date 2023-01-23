using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficStaticCollisionSphere : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("worldPos")] 
		public Vector3 WorldPos
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public worldTrafficStaticCollisionSphere()
		{
			WorldPos = new() { X = float.PositiveInfinity, Y = float.PositiveInfinity, Z = float.PositiveInfinity };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
