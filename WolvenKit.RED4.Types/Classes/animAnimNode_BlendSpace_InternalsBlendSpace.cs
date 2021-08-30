using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_BlendSpace_InternalsBlendSpace : RedBaseClass
	{
		private CUInt32 _spaceDimension;
		private CArray<animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription> _coordinatesDescriptions;
		private CArray<animAnimNode_BlendSpace_InternalsBlendSpacePoint> _spacePoints;
		private CUInt32 _boundaryPointsCount;
		private CBool _fireAnimEndEvent;
		private CName _animEndEventName;
		private CBool _isLooped;
		private CBool _needsRuntimeTriangulation;
		private CBool _wasRuntimeTriangulationResaveDone;
		private CArray<CFloat> _cachedSpacePoints_coordinates;
		private CArray<CUInt32> _cachedSpaceSimplexes_pointsIndices;
		private CArray<CInt32> _cachedSamplesForGridPoints_simplexIndex;
		private CArray<CFloat> _cachedSamplesForGridPoints_weightsForPoints;

		[Ordinal(0)] 
		[RED("spaceDimension")] 
		public CUInt32 SpaceDimension
		{
			get => GetProperty(ref _spaceDimension);
			set => SetProperty(ref _spaceDimension, value);
		}

		[Ordinal(1)] 
		[RED("coordinatesDescriptions")] 
		public CArray<animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription> CoordinatesDescriptions
		{
			get => GetProperty(ref _coordinatesDescriptions);
			set => SetProperty(ref _coordinatesDescriptions, value);
		}

		[Ordinal(2)] 
		[RED("spacePoints")] 
		public CArray<animAnimNode_BlendSpace_InternalsBlendSpacePoint> SpacePoints
		{
			get => GetProperty(ref _spacePoints);
			set => SetProperty(ref _spacePoints, value);
		}

		[Ordinal(3)] 
		[RED("boundaryPointsCount")] 
		public CUInt32 BoundaryPointsCount
		{
			get => GetProperty(ref _boundaryPointsCount);
			set => SetProperty(ref _boundaryPointsCount, value);
		}

		[Ordinal(4)] 
		[RED("fireAnimEndEvent")] 
		public CBool FireAnimEndEvent
		{
			get => GetProperty(ref _fireAnimEndEvent);
			set => SetProperty(ref _fireAnimEndEvent, value);
		}

		[Ordinal(5)] 
		[RED("animEndEventName")] 
		public CName AnimEndEventName
		{
			get => GetProperty(ref _animEndEventName);
			set => SetProperty(ref _animEndEventName, value);
		}

		[Ordinal(6)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get => GetProperty(ref _isLooped);
			set => SetProperty(ref _isLooped, value);
		}

		[Ordinal(7)] 
		[RED("needsRuntimeTriangulation")] 
		public CBool NeedsRuntimeTriangulation
		{
			get => GetProperty(ref _needsRuntimeTriangulation);
			set => SetProperty(ref _needsRuntimeTriangulation, value);
		}

		[Ordinal(8)] 
		[RED("wasRuntimeTriangulationResaveDone")] 
		public CBool WasRuntimeTriangulationResaveDone
		{
			get => GetProperty(ref _wasRuntimeTriangulationResaveDone);
			set => SetProperty(ref _wasRuntimeTriangulationResaveDone, value);
		}

		[Ordinal(9)] 
		[RED("cachedSpacePoints_coordinates")] 
		public CArray<CFloat> CachedSpacePoints_coordinates
		{
			get => GetProperty(ref _cachedSpacePoints_coordinates);
			set => SetProperty(ref _cachedSpacePoints_coordinates, value);
		}

		[Ordinal(10)] 
		[RED("cachedSpaceSimplexes_pointsIndices")] 
		public CArray<CUInt32> CachedSpaceSimplexes_pointsIndices
		{
			get => GetProperty(ref _cachedSpaceSimplexes_pointsIndices);
			set => SetProperty(ref _cachedSpaceSimplexes_pointsIndices, value);
		}

		[Ordinal(11)] 
		[RED("cachedSamplesForGridPoints_simplexIndex")] 
		public CArray<CInt32> CachedSamplesForGridPoints_simplexIndex
		{
			get => GetProperty(ref _cachedSamplesForGridPoints_simplexIndex);
			set => SetProperty(ref _cachedSamplesForGridPoints_simplexIndex, value);
		}

		[Ordinal(12)] 
		[RED("cachedSamplesForGridPoints_weightsForPoints")] 
		public CArray<CFloat> CachedSamplesForGridPoints_weightsForPoints
		{
			get => GetProperty(ref _cachedSamplesForGridPoints_weightsForPoints);
			set => SetProperty(ref _cachedSamplesForGridPoints_weightsForPoints, value);
		}

		public animAnimNode_BlendSpace_InternalsBlendSpace()
		{
			_spaceDimension = 1;
			_isLooped = true;
			_needsRuntimeTriangulation = true;
		}
	}
}
