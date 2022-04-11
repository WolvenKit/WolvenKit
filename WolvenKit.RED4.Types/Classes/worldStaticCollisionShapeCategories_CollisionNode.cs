using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldStaticCollisionShapeCategories_CollisionNode : RedBaseClass
	{
        // TODO: Wrong type, was lazy, should work
        [Ordinal(0)]
        [RED("arr", 5, 6)]
        public CArrayFixedSize<CArrayFixedSize<CUInt16>> Arr
        {
            get => GetPropertyValue<CArrayFixedSize<CArrayFixedSize<CUInt16>>>();
            set => SetPropertyValue<CArrayFixedSize<CArrayFixedSize<CUInt16>>>(value);
        }

        public worldStaticCollisionShapeCategories_CollisionNode()
        {
            Arr = new(5);
        }
    }
}
