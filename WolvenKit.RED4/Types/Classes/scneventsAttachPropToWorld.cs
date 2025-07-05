using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
		[RED("fallbackData")] 
		public CArray<scneventsAttachPropToWorldFallbackData> FallbackData
		{
			get => GetPropertyValue<CArray<scneventsAttachPropToWorldFallbackData>>();
			set => SetPropertyValue<CArray<scneventsAttachPropToWorldFallbackData>>(value);
		}

		public scneventsAttachPropToWorld()
		{
			Id = new scnSceneEventId { Id = long.MaxValue };
			PropId = new scnPropId { Id = uint.MaxValue };
			CustomOffsetPos = new Vector3();
			CustomOffsetRot = new Quaternion { R = 1.000000F };
			ReferencePerformer = new scnPerformerId { Id = 4294967040 };
			FallbackData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
