using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scneventsAttachPropToWorld : scnSceneEvent
	{
		private scnPropId _propId;
		private CEnum<scnOffsetMode> _offsetMode;
		private Vector3 _customOffsetPos;
		private Quaternion _customOffsetRot;
		private scnPerformerId _referencePerformer;
		private TweakDBID _referencePerformerSlotId;
		private TweakDBID _referencePerformerItemId;
		private CStatic<scneventsAttachPropToWorldCachedFallbackBone> _fallbackCachedBones;
		private CResourceReference<animAnimSet> _fallbackAnimset;
		private CName _fallbackAnimationName;
		private CFloat _fallbackAnimTime;

		[Ordinal(6)] 
		[RED("propId")] 
		public scnPropId PropId
		{
			get => GetProperty(ref _propId);
			set => SetProperty(ref _propId, value);
		}

		[Ordinal(7)] 
		[RED("offsetMode")] 
		public CEnum<scnOffsetMode> OffsetMode
		{
			get => GetProperty(ref _offsetMode);
			set => SetProperty(ref _offsetMode, value);
		}

		[Ordinal(8)] 
		[RED("customOffsetPos")] 
		public Vector3 CustomOffsetPos
		{
			get => GetProperty(ref _customOffsetPos);
			set => SetProperty(ref _customOffsetPos, value);
		}

		[Ordinal(9)] 
		[RED("customOffsetRot")] 
		public Quaternion CustomOffsetRot
		{
			get => GetProperty(ref _customOffsetRot);
			set => SetProperty(ref _customOffsetRot, value);
		}

		[Ordinal(10)] 
		[RED("referencePerformer")] 
		public scnPerformerId ReferencePerformer
		{
			get => GetProperty(ref _referencePerformer);
			set => SetProperty(ref _referencePerformer, value);
		}

		[Ordinal(11)] 
		[RED("referencePerformerSlotId")] 
		public TweakDBID ReferencePerformerSlotId
		{
			get => GetProperty(ref _referencePerformerSlotId);
			set => SetProperty(ref _referencePerformerSlotId, value);
		}

		[Ordinal(12)] 
		[RED("referencePerformerItemId")] 
		public TweakDBID ReferencePerformerItemId
		{
			get => GetProperty(ref _referencePerformerItemId);
			set => SetProperty(ref _referencePerformerItemId, value);
		}

		[Ordinal(13)] 
		[RED("fallbackCachedBones", 2)] 
		public CStatic<scneventsAttachPropToWorldCachedFallbackBone> FallbackCachedBones
		{
			get => GetProperty(ref _fallbackCachedBones);
			set => SetProperty(ref _fallbackCachedBones, value);
		}

		[Ordinal(14)] 
		[RED("fallbackAnimset")] 
		public CResourceReference<animAnimSet> FallbackAnimset
		{
			get => GetProperty(ref _fallbackAnimset);
			set => SetProperty(ref _fallbackAnimset, value);
		}

		[Ordinal(15)] 
		[RED("fallbackAnimationName")] 
		public CName FallbackAnimationName
		{
			get => GetProperty(ref _fallbackAnimationName);
			set => SetProperty(ref _fallbackAnimationName, value);
		}

		[Ordinal(16)] 
		[RED("fallbackAnimTime")] 
		public CFloat FallbackAnimTime
		{
			get => GetProperty(ref _fallbackAnimTime);
			set => SetProperty(ref _fallbackAnimTime, value);
		}
	}
}
