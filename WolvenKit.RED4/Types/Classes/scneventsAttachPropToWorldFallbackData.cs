using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsAttachPropToWorldFallbackData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public scnPerformerId Owner
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(1)] 
		[RED("fallbackCachedBones", 2)] 
		public CStatic<scneventsAttachPropToWorldCachedFallbackBone> FallbackCachedBones
		{
			get => GetPropertyValue<CStatic<scneventsAttachPropToWorldCachedFallbackBone>>();
			set => SetPropertyValue<CStatic<scneventsAttachPropToWorldCachedFallbackBone>>(value);
		}

		[Ordinal(2)] 
		[RED("fallbackAnimset")] 
		public CResourceReference<animAnimSet> FallbackAnimset
		{
			get => GetPropertyValue<CResourceReference<animAnimSet>>();
			set => SetPropertyValue<CResourceReference<animAnimSet>>(value);
		}

		[Ordinal(3)] 
		[RED("fallbackAnimationName")] 
		public CName FallbackAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("fallbackAnimTime")] 
		public CFloat FallbackAnimTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public scneventsAttachPropToWorldFallbackData()
		{
			Owner = new scnPerformerId { Id = 4294967040 };
			FallbackCachedBones = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
