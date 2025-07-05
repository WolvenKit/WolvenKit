using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_ReadIkRequest : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("ikChain")] 
		public CName IkChain
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("outTransform")] 
		public animTransformIndex OutTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		public animAnimNode_ReadIkRequest()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			OutTransform = new animTransformIndex();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
