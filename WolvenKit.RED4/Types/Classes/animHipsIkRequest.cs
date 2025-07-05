using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animHipsIkRequest : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("leftLegIkChain")] 
		public CName LeftLegIkChain
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("rightLegIkChain")] 
		public CName RightLegIkChain
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("hipsTransformIndex")] 
		public animTransformIndex HipsTransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(3)] 
		[RED("leftFootTransformIndex")] 
		public animTransformIndex LeftFootTransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(4)] 
		[RED("rightFootTransformIndex")] 
		public animTransformIndex RightFootTransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		public animHipsIkRequest()
		{
			HipsTransformIndex = new animTransformIndex();
			LeftFootTransformIndex = new animTransformIndex();
			RightFootTransformIndex = new animTransformIndex();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
