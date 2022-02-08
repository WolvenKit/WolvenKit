using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scneventsAttachPropToWorld : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("propId")] 
		public scnPropId PropId
		{
			get => GetPropertyValue<scnPropId>();
			set => SetPropertyValue<scnPropId>(value);
		}

		[Ordinal(7)] 
		[RED("offsetMode")] 
		public CEnum<scnOffsetMode> OffsetMode
		{
			get => GetPropertyValue<CEnum<scnOffsetMode>>();
			set => SetPropertyValue<CEnum<scnOffsetMode>>(value);
		}

		[Ordinal(8)] 
		[RED("customOffsetPos")] 
		public Vector3 CustomOffsetPos
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(9)] 
		[RED("customOffsetRot")] 
		public Quaternion CustomOffsetRot
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(10)] 
		[RED("referencePerformer")] 
		public scnPerformerId ReferencePerformer
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(11)] 
		[RED("referencePerformerSlotId")] 
		public TweakDBID ReferencePerformerSlotId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(12)] 
		[RED("referencePerformerItemId")] 
		public TweakDBID ReferencePerformerItemId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(13)] 
		[RED("fallbackCachedBones", 2)] 
		public CStatic<scneventsAttachPropToWorldCachedFallbackBone> FallbackCachedBones
		{
			get => GetPropertyValue<CStatic<scneventsAttachPropToWorldCachedFallbackBone>>();
			set => SetPropertyValue<CStatic<scneventsAttachPropToWorldCachedFallbackBone>>(value);
		}

		[Ordinal(14)] 
		[RED("fallbackAnimset")] 
		public CResourceReference<animAnimSet> FallbackAnimset
		{
			get => GetPropertyValue<CResourceReference<animAnimSet>>();
			set => SetPropertyValue<CResourceReference<animAnimSet>>(value);
		}

		[Ordinal(15)] 
		[RED("fallbackAnimationName")] 
		public CName FallbackAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("fallbackAnimTime")] 
		public CFloat FallbackAnimTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public scneventsAttachPropToWorld()
		{
			Id = new() { Id = 18446744073709551615 };
			PropId = new() { Id = 4294967295 };
			CustomOffsetPos = new();
			CustomOffsetRot = new() { R = 1.000000F };
			ReferencePerformer = new() { Id = 4294967040 };
			FallbackCachedBones = new(0);
		}
	}
}
