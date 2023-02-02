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
			Translation = new();
			Rotation = new() { R = 1.000000F };
			LocalTransform = new();
			ComponentNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
