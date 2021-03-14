using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendSpace_InternalsBlendSpace : CVariable
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
			get
			{
				if (_spaceDimension == null)
				{
					_spaceDimension = (CUInt32) CR2WTypeManager.Create("Uint32", "spaceDimension", cr2w, this);
				}
				return _spaceDimension;
			}
			set
			{
				if (_spaceDimension == value)
				{
					return;
				}
				_spaceDimension = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("coordinatesDescriptions")] 
		public CArray<animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription> CoordinatesDescriptions
		{
			get
			{
				if (_coordinatesDescriptions == null)
				{
					_coordinatesDescriptions = (CArray<animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription>) CR2WTypeManager.Create("array:animAnimNode_BlendSpace_InternalsBlendSpaceCoordinateDescription", "coordinatesDescriptions", cr2w, this);
				}
				return _coordinatesDescriptions;
			}
			set
			{
				if (_coordinatesDescriptions == value)
				{
					return;
				}
				_coordinatesDescriptions = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("spacePoints")] 
		public CArray<animAnimNode_BlendSpace_InternalsBlendSpacePoint> SpacePoints
		{
			get
			{
				if (_spacePoints == null)
				{
					_spacePoints = (CArray<animAnimNode_BlendSpace_InternalsBlendSpacePoint>) CR2WTypeManager.Create("array:animAnimNode_BlendSpace_InternalsBlendSpacePoint", "spacePoints", cr2w, this);
				}
				return _spacePoints;
			}
			set
			{
				if (_spacePoints == value)
				{
					return;
				}
				_spacePoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("boundaryPointsCount")] 
		public CUInt32 BoundaryPointsCount
		{
			get
			{
				if (_boundaryPointsCount == null)
				{
					_boundaryPointsCount = (CUInt32) CR2WTypeManager.Create("Uint32", "boundaryPointsCount", cr2w, this);
				}
				return _boundaryPointsCount;
			}
			set
			{
				if (_boundaryPointsCount == value)
				{
					return;
				}
				_boundaryPointsCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("fireAnimEndEvent")] 
		public CBool FireAnimEndEvent
		{
			get
			{
				if (_fireAnimEndEvent == null)
				{
					_fireAnimEndEvent = (CBool) CR2WTypeManager.Create("Bool", "fireAnimEndEvent", cr2w, this);
				}
				return _fireAnimEndEvent;
			}
			set
			{
				if (_fireAnimEndEvent == value)
				{
					return;
				}
				_fireAnimEndEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("animEndEventName")] 
		public CName AnimEndEventName
		{
			get
			{
				if (_animEndEventName == null)
				{
					_animEndEventName = (CName) CR2WTypeManager.Create("CName", "animEndEventName", cr2w, this);
				}
				return _animEndEventName;
			}
			set
			{
				if (_animEndEventName == value)
				{
					return;
				}
				_animEndEventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get
			{
				if (_isLooped == null)
				{
					_isLooped = (CBool) CR2WTypeManager.Create("Bool", "isLooped", cr2w, this);
				}
				return _isLooped;
			}
			set
			{
				if (_isLooped == value)
				{
					return;
				}
				_isLooped = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("needsRuntimeTriangulation")] 
		public CBool NeedsRuntimeTriangulation
		{
			get
			{
				if (_needsRuntimeTriangulation == null)
				{
					_needsRuntimeTriangulation = (CBool) CR2WTypeManager.Create("Bool", "needsRuntimeTriangulation", cr2w, this);
				}
				return _needsRuntimeTriangulation;
			}
			set
			{
				if (_needsRuntimeTriangulation == value)
				{
					return;
				}
				_needsRuntimeTriangulation = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("wasRuntimeTriangulationResaveDone")] 
		public CBool WasRuntimeTriangulationResaveDone
		{
			get
			{
				if (_wasRuntimeTriangulationResaveDone == null)
				{
					_wasRuntimeTriangulationResaveDone = (CBool) CR2WTypeManager.Create("Bool", "wasRuntimeTriangulationResaveDone", cr2w, this);
				}
				return _wasRuntimeTriangulationResaveDone;
			}
			set
			{
				if (_wasRuntimeTriangulationResaveDone == value)
				{
					return;
				}
				_wasRuntimeTriangulationResaveDone = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("cachedSpacePoints_coordinates")] 
		public CArray<CFloat> CachedSpacePoints_coordinates
		{
			get
			{
				if (_cachedSpacePoints_coordinates == null)
				{
					_cachedSpacePoints_coordinates = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "cachedSpacePoints_coordinates", cr2w, this);
				}
				return _cachedSpacePoints_coordinates;
			}
			set
			{
				if (_cachedSpacePoints_coordinates == value)
				{
					return;
				}
				_cachedSpacePoints_coordinates = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("cachedSpaceSimplexes_pointsIndices")] 
		public CArray<CUInt32> CachedSpaceSimplexes_pointsIndices
		{
			get
			{
				if (_cachedSpaceSimplexes_pointsIndices == null)
				{
					_cachedSpaceSimplexes_pointsIndices = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "cachedSpaceSimplexes_pointsIndices", cr2w, this);
				}
				return _cachedSpaceSimplexes_pointsIndices;
			}
			set
			{
				if (_cachedSpaceSimplexes_pointsIndices == value)
				{
					return;
				}
				_cachedSpaceSimplexes_pointsIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("cachedSamplesForGridPoints_simplexIndex")] 
		public CArray<CInt32> CachedSamplesForGridPoints_simplexIndex
		{
			get
			{
				if (_cachedSamplesForGridPoints_simplexIndex == null)
				{
					_cachedSamplesForGridPoints_simplexIndex = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "cachedSamplesForGridPoints_simplexIndex", cr2w, this);
				}
				return _cachedSamplesForGridPoints_simplexIndex;
			}
			set
			{
				if (_cachedSamplesForGridPoints_simplexIndex == value)
				{
					return;
				}
				_cachedSamplesForGridPoints_simplexIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("cachedSamplesForGridPoints_weightsForPoints")] 
		public CArray<CFloat> CachedSamplesForGridPoints_weightsForPoints
		{
			get
			{
				if (_cachedSamplesForGridPoints_weightsForPoints == null)
				{
					_cachedSamplesForGridPoints_weightsForPoints = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "cachedSamplesForGridPoints_weightsForPoints", cr2w, this);
				}
				return _cachedSamplesForGridPoints_weightsForPoints;
			}
			set
			{
				if (_cachedSamplesForGridPoints_weightsForPoints == value)
				{
					return;
				}
				_cachedSamplesForGridPoints_weightsForPoints = value;
				PropertySet(this);
			}
		}

		public animAnimNode_BlendSpace_InternalsBlendSpace(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
