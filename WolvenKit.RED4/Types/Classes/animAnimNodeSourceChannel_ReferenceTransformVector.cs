using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNodeSourceChannel_ReferenceTransformVector : animIAnimNodeSourceChannel_Vector
	{
		[Ordinal(0)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		public animAnimNodeSourceChannel_ReferenceTransformVector()
		{
			TransformIndex = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
