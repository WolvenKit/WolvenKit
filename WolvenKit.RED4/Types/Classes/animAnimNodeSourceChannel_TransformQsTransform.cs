using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNodeSourceChannel_TransformQsTransform : animIAnimNodeSourceChannel_QsTransform
	{
		[Ordinal(0)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		public animAnimNodeSourceChannel_TransformQsTransform()
		{
			TransformIndex = new animTransformIndex();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
