using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAdditionalTransformEntry : ISerializable
	{
		[Ordinal(0)] 
		[RED("transformInfo")] 
		public animTransformInfo TransformInfo
		{
			get => GetPropertyValue<animTransformInfo>();
			set => SetPropertyValue<animTransformInfo>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public QsTransform Value
		{
			get => GetPropertyValue<QsTransform>();
			set => SetPropertyValue<QsTransform>(value);
		}

		public animAdditionalTransformEntry()
		{
			TransformInfo = new animTransformInfo();
			Value = new QsTransform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
