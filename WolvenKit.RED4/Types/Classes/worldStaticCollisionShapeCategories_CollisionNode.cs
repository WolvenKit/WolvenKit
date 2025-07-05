using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStaticCollisionShapeCategories_CollisionNode : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("arr", 5, 6)] 
		public CArrayFixedSize<CArrayFixedSize<CUInt16>> Arr
		{
			get => GetPropertyValue<CArrayFixedSize<CArrayFixedSize<CUInt16>>>();
			set => SetPropertyValue<CArrayFixedSize<CArrayFixedSize<CUInt16>>>(value);
		}

		public worldStaticCollisionShapeCategories_CollisionNode()
		{
			Arr = new(5, 6);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
