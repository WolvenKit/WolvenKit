using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_AdditionalTransform : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("additionalTransforms")] 
		public animAdditionalTransformContainer AdditionalTransforms
		{
			get => GetPropertyValue<animAdditionalTransformContainer>();
			set => SetPropertyValue<animAdditionalTransformContainer>(value);
		}

		public animAnimNode_AdditionalTransform()
		{
			Id = 4294967295;
			InputLink = new();
			AdditionalTransforms = new() { Entries = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
