using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_BlendSpace : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("inputLinks")] 
		public CArray<animFloatLink> InputLinks
		{
			get => GetPropertyValue<CArray<animFloatLink>>();
			set => SetPropertyValue<CArray<animFloatLink>>(value);
		}

		[Ordinal(12)] 
		[RED("blendSpace")] 
		public animAnimNode_BlendSpace_InternalsBlendSpace BlendSpace
		{
			get => GetPropertyValue<animAnimNode_BlendSpace_InternalsBlendSpace>();
			set => SetPropertyValue<animAnimNode_BlendSpace_InternalsBlendSpace>(value);
		}

		[Ordinal(13)] 
		[RED("progressLink")] 
		public animFloatLink ProgressLink
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(14)] 
		[RED("fireAnimEndEvent")] 
		public CBool FireAnimEndEvent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("animEndEventName")] 
		public CName AnimEndEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_BlendSpace()
		{
			Id = 4294967295;
			InputLinks = new() { new() };
			BlendSpace = new() { SpaceDimension = 1, CoordinatesDescriptions = new() { new() }, SpacePoints = new(), IsLooped = true, NeedsRuntimeTriangulation = true, CachedSpacePoints_coordinates = new(), CachedSpaceSimplexes_pointsIndices = new(), CachedSamplesForGridPoints_simplexIndex = new(), CachedSamplesForGridPoints_weightsForPoints = new() };
			ProgressLink = new();
			IsLooped = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
