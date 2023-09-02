using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameHitRepresentationComponent : entSlotComponent
	{
		[Ordinal(7)] 
		[RED("representations")] 
		public CArray<gameHitShapeContainer> Representations
		{
			get => GetPropertyValue<CArray<gameHitShapeContainer>>();
			set => SetPropertyValue<CArray<gameHitShapeContainer>>(value);
		}

		[Ordinal(8)] 
		[RED("physicsMaterial")] 
		public CName PhysicsMaterial
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("bvhRoot")] 
		public gameHitShapeBVH BvhRoot
		{
			get => GetPropertyValue<gameHitShapeBVH>();
			set => SetPropertyValue<gameHitShapeBVH>(value);
		}

		[Ordinal(10)] 
		[RED("useResourceData")] 
		public CBool UseResourceData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("resource")] 
		public CResourceAsyncReference<gameHitRepresentationResource> Resource
		{
			get => GetPropertyValue<CResourceAsyncReference<gameHitRepresentationResource>>();
			set => SetPropertyValue<CResourceAsyncReference<gameHitRepresentationResource>>(value);
		}

		[Ordinal(12)] 
		[RED("appearanceOverrides")] 
		public CArray<gameHitRepresentationOverride> AppearanceOverrides
		{
			get => GetPropertyValue<CArray<gameHitRepresentationOverride>>();
			set => SetPropertyValue<CArray<gameHitRepresentationOverride>>(value);
		}

		public gameHitRepresentationComponent()
		{
			Representations = new();
			BvhRoot = new gameHitShapeBVH { ChildrenNodes = new(), ChildrenShapeNames = new() };
			AppearanceOverrides = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
