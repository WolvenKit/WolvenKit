using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsSpawnEntityEventParams : CVariable
	{
		private scnPerformerId _performer;
		private scnPerformerId _referencePerformer;
		private TweakDBID _referencePerformerSlotId;
		private TweakDBID _referencePerformerItemId;
		private CStatic<scneventsSpawnEntityEventCachedFallbackBone> _fallbackCachedBones;
		private rRef<animAnimSet> _fallbackAnimset;
		private CName _fallbackAnimationName;
		private CFloat _fallbackAnimTime;

		[Ordinal(0)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetProperty(ref _performer);
			set => SetProperty(ref _performer, value);
		}

		[Ordinal(1)] 
		[RED("referencePerformer")] 
		public scnPerformerId ReferencePerformer
		{
			get => GetProperty(ref _referencePerformer);
			set => SetProperty(ref _referencePerformer, value);
		}

		[Ordinal(2)] 
		[RED("referencePerformerSlotId")] 
		public TweakDBID ReferencePerformerSlotId
		{
			get => GetProperty(ref _referencePerformerSlotId);
			set => SetProperty(ref _referencePerformerSlotId, value);
		}

		[Ordinal(3)] 
		[RED("referencePerformerItemId")] 
		public TweakDBID ReferencePerformerItemId
		{
			get => GetProperty(ref _referencePerformerItemId);
			set => SetProperty(ref _referencePerformerItemId, value);
		}

		[Ordinal(4)] 
		[RED("fallbackCachedBones", 2)] 
		public CStatic<scneventsSpawnEntityEventCachedFallbackBone> FallbackCachedBones
		{
			get => GetProperty(ref _fallbackCachedBones);
			set => SetProperty(ref _fallbackCachedBones, value);
		}

		[Ordinal(5)] 
		[RED("fallbackAnimset")] 
		public rRef<animAnimSet> FallbackAnimset
		{
			get => GetProperty(ref _fallbackAnimset);
			set => SetProperty(ref _fallbackAnimset, value);
		}

		[Ordinal(6)] 
		[RED("fallbackAnimationName")] 
		public CName FallbackAnimationName
		{
			get => GetProperty(ref _fallbackAnimationName);
			set => SetProperty(ref _fallbackAnimationName, value);
		}

		[Ordinal(7)] 
		[RED("fallbackAnimTime")] 
		public CFloat FallbackAnimTime
		{
			get => GetProperty(ref _fallbackAnimTime);
			set => SetProperty(ref _fallbackAnimTime, value);
		}

		public scneventsSpawnEntityEventParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
