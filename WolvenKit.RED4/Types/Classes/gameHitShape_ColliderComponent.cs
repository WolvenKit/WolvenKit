using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameHitShape_ColliderComponent : gameHitShapeBase
	{
		[Ordinal(3)] 
		[RED("componentNames")] 
		public CArray<CName> ComponentNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gameHitShape_ColliderComponent()
		{
			Translation = new Vector3();
			Rotation = new Quaternion { R = 1.000000F };
			LocalTransform = new CMatrix();
			ComponentNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
