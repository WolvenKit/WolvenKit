using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_BlendSpace_InternalsBlendSpace : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("spaceDimension")] 
		public CUInt32 SpaceDimension
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("coordinatesDescriptions")] 
		public CArray<animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription> CoordinatesDescriptions
		{
			get => GetPropertyValue<CArray<animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription>>();
			set => SetPropertyValue<CArray<animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription>>(value);
		}

		[Ordinal(2)] 
		[RED("spacePoints")] 
		public CArray<animAnimNode_BlendSpace_InternalsBlendSpacePoint> SpacePoints
		{
			get => GetPropertyValue<CArray<animAnimNode_BlendSpace_InternalsBlendSpacePoint>>();
			set => SetPropertyValue<CArray<animAnimNode_BlendSpace_InternalsBlendSpacePoint>>(value);
		}

		[Ordinal(3)] 
		[RED("boundaryPointsCount")] 
		public CUInt32 BoundaryPointsCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("fireAnimEndEvent")] 
		public CBool FireAnimEndEvent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("animEndEventName")] 
		public CName AnimEndEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("needsRuntimeTriangulation")] 
		public CBool NeedsRuntimeTriangulation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("wasRuntimeTriangulationResaveDone")] 
		public CBool WasRuntimeTriangulationResaveDone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("cachedSpacePoints_coordinates")] 
		public CArray<CFloat> CachedSpacePoints_coordinates
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(10)] 
		[RED("cachedSpaceSimplexes_pointsIndices")] 
		public CArray<CUInt32> CachedSpaceSimplexes_pointsIndices
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(11)] 
		[RED("cachedSamplesForGridPoints_simplexIndex")] 
		public CArray<CInt32> CachedSamplesForGridPoints_simplexIndex
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		[Ordinal(12)] 
		[RED("cachedSamplesForGridPoints_weightsForPoints")] 
		public CArray<CFloat> CachedSamplesForGridPoints_weightsForPoints
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		public animAnimNode_BlendSpace_InternalsBlendSpace()
		{
			SpaceDimension = 1;
			CoordinatesDescriptions = new() { new animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription() };
			SpacePoints = new();
			IsLooped = true;
			NeedsRuntimeTriangulation = true;
			CachedSpacePoints_coordinates = new();
			CachedSpaceSimplexes_pointsIndices = new();
			CachedSamplesForGridPoints_simplexIndex = new();
			CachedSamplesForGridPoints_weightsForPoints = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
