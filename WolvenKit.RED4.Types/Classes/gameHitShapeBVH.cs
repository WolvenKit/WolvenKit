using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameHitShapeBVH : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("nodeName")] 
		public CName NodeName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("childrenNodes")] 
		public CArray<gameHitShapeBVH> ChildrenNodes
		{
			get => GetPropertyValue<CArray<gameHitShapeBVH>>();
			set => SetPropertyValue<CArray<gameHitShapeBVH>>(value);
		}

		[Ordinal(2)] 
		[RED("childrenShapeNames")] 
		public CArray<CName> ChildrenShapeNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gameHitShapeBVH()
		{
			ChildrenNodes = new();
			ChildrenShapeNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
