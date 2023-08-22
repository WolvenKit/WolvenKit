using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameHitShape_OBB : gameHitShapeBase
	{
		[Ordinal(3)] 
		[RED("dimensions")] 
		public Vector3 Dimensions
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public gameHitShape_OBB()
		{
			Translation = new Vector3();
			Rotation = new Quaternion { R = 1.000000F };
			LocalTransform = new CMatrix();
			Dimensions = new Vector3 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
