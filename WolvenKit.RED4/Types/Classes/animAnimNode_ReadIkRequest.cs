using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_ReadIkRequest : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("ikChain")] 
		public CName IkChain
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
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
