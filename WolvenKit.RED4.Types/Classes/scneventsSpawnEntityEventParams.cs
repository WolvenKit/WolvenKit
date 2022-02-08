using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scneventsSpawnEntityEventParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(1)] 
		[RED("referencePerformer")] 
		public scnPerformerId ReferencePerformer
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(2)] 
		[RED("referencePerformerSlotId")] 
		public TweakDBID ReferencePerformerSlotId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("referencePerformerItemId")] 
		public TweakDBID ReferencePerformerItemId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("fallbackCachedBones", 2)] 
		public CStatic<scneventsSpawnEntityEventCachedFallbackBone> FallbackCachedBones
		{
			get => GetPropertyValue<CStatic<scneventsSpawnEntityEventCachedFallbackBone>>();
			set => SetPropertyValue<CStatic<scneventsSpawnEntityEventCachedFallbackBone>>(value);
		}

		[Ordinal(5)] 
		[RED("fallbackAnimset")] 
		public CResourceReference<animAnimSet> FallbackAnimset
		{
			get => GetPropertyValue<CResourceReference<animAnimSet>>();
			set => SetPropertyValue<CResourceReference<animAnimSet>>(value);
		}

		[Ordinal(6)] 
		[RED("fallbackAnimationName")] 
		public CName FallbackAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("fallbackAnimTime")] 
		public CFloat FallbackAnimTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public scneventsSpawnEntityEventParams()
		{
			Performer = new() { Id = 4294967040 };
			ReferencePerformer = new() { Id = 4294967040 };
			FallbackCachedBones = new(0);
		}
	}
}
