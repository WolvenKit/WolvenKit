using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animFacialSetup_OneSermoBufferInfo : CVariable
	{
		private CUInt16 _numGlobalLimits;
		private CUInt16 _numInfluencedPoses;
		private CUInt16 _numInfluenceIndices;
		private CUInt16 _numUpperLowerFace;
		private CUInt16 _numLipsyncPosesSides;
		private CUInt16 _numAllCorrectives;
		private CUInt16 _numGlobalCorrectiveEntries;
		private CUInt16 _numInbetweenCorrectiveEntries;
		private CUInt16 _numCorrectiveInfluencedPoses;
		private CUInt16 _numCorrectiveInfluenceIndices;
		private CUInt16 _numAllMainPoses;
		private CUInt16 _numAllMainPosesInbetweens;
		private CUInt16 _numAllMainPosesInbetweenScopeMultipliers;
		private CUInt16 _numEnvelopesPerTrackMapping;
		private CUInt16 _wrinkleStartingIndex;
		private CUInt16 _numWrinkles;

		[Ordinal(0)] 
		[RED("numGlobalLimits")] 
		public CUInt16 NumGlobalLimits
		{
			get
			{
				if (_numGlobalLimits == null)
				{
					_numGlobalLimits = (CUInt16) CR2WTypeManager.Create("Uint16", "numGlobalLimits", cr2w, this);
				}
				return _numGlobalLimits;
			}
			set
			{
				if (_numGlobalLimits == value)
				{
					return;
				}
				_numGlobalLimits = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("numInfluencedPoses")] 
		public CUInt16 NumInfluencedPoses
		{
			get
			{
				if (_numInfluencedPoses == null)
				{
					_numInfluencedPoses = (CUInt16) CR2WTypeManager.Create("Uint16", "numInfluencedPoses", cr2w, this);
				}
				return _numInfluencedPoses;
			}
			set
			{
				if (_numInfluencedPoses == value)
				{
					return;
				}
				_numInfluencedPoses = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("numInfluenceIndices")] 
		public CUInt16 NumInfluenceIndices
		{
			get
			{
				if (_numInfluenceIndices == null)
				{
					_numInfluenceIndices = (CUInt16) CR2WTypeManager.Create("Uint16", "numInfluenceIndices", cr2w, this);
				}
				return _numInfluenceIndices;
			}
			set
			{
				if (_numInfluenceIndices == value)
				{
					return;
				}
				_numInfluenceIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("numUpperLowerFace")] 
		public CUInt16 NumUpperLowerFace
		{
			get
			{
				if (_numUpperLowerFace == null)
				{
					_numUpperLowerFace = (CUInt16) CR2WTypeManager.Create("Uint16", "numUpperLowerFace", cr2w, this);
				}
				return _numUpperLowerFace;
			}
			set
			{
				if (_numUpperLowerFace == value)
				{
					return;
				}
				_numUpperLowerFace = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("numLipsyncPosesSides")] 
		public CUInt16 NumLipsyncPosesSides
		{
			get
			{
				if (_numLipsyncPosesSides == null)
				{
					_numLipsyncPosesSides = (CUInt16) CR2WTypeManager.Create("Uint16", "numLipsyncPosesSides", cr2w, this);
				}
				return _numLipsyncPosesSides;
			}
			set
			{
				if (_numLipsyncPosesSides == value)
				{
					return;
				}
				_numLipsyncPosesSides = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("numAllCorrectives")] 
		public CUInt16 NumAllCorrectives
		{
			get
			{
				if (_numAllCorrectives == null)
				{
					_numAllCorrectives = (CUInt16) CR2WTypeManager.Create("Uint16", "numAllCorrectives", cr2w, this);
				}
				return _numAllCorrectives;
			}
			set
			{
				if (_numAllCorrectives == value)
				{
					return;
				}
				_numAllCorrectives = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("numGlobalCorrectiveEntries")] 
		public CUInt16 NumGlobalCorrectiveEntries
		{
			get
			{
				if (_numGlobalCorrectiveEntries == null)
				{
					_numGlobalCorrectiveEntries = (CUInt16) CR2WTypeManager.Create("Uint16", "numGlobalCorrectiveEntries", cr2w, this);
				}
				return _numGlobalCorrectiveEntries;
			}
			set
			{
				if (_numGlobalCorrectiveEntries == value)
				{
					return;
				}
				_numGlobalCorrectiveEntries = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("numInbetweenCorrectiveEntries")] 
		public CUInt16 NumInbetweenCorrectiveEntries
		{
			get
			{
				if (_numInbetweenCorrectiveEntries == null)
				{
					_numInbetweenCorrectiveEntries = (CUInt16) CR2WTypeManager.Create("Uint16", "numInbetweenCorrectiveEntries", cr2w, this);
				}
				return _numInbetweenCorrectiveEntries;
			}
			set
			{
				if (_numInbetweenCorrectiveEntries == value)
				{
					return;
				}
				_numInbetweenCorrectiveEntries = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("numCorrectiveInfluencedPoses")] 
		public CUInt16 NumCorrectiveInfluencedPoses
		{
			get
			{
				if (_numCorrectiveInfluencedPoses == null)
				{
					_numCorrectiveInfluencedPoses = (CUInt16) CR2WTypeManager.Create("Uint16", "numCorrectiveInfluencedPoses", cr2w, this);
				}
				return _numCorrectiveInfluencedPoses;
			}
			set
			{
				if (_numCorrectiveInfluencedPoses == value)
				{
					return;
				}
				_numCorrectiveInfluencedPoses = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("numCorrectiveInfluenceIndices")] 
		public CUInt16 NumCorrectiveInfluenceIndices
		{
			get
			{
				if (_numCorrectiveInfluenceIndices == null)
				{
					_numCorrectiveInfluenceIndices = (CUInt16) CR2WTypeManager.Create("Uint16", "numCorrectiveInfluenceIndices", cr2w, this);
				}
				return _numCorrectiveInfluenceIndices;
			}
			set
			{
				if (_numCorrectiveInfluenceIndices == value)
				{
					return;
				}
				_numCorrectiveInfluenceIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("numAllMainPoses")] 
		public CUInt16 NumAllMainPoses
		{
			get
			{
				if (_numAllMainPoses == null)
				{
					_numAllMainPoses = (CUInt16) CR2WTypeManager.Create("Uint16", "numAllMainPoses", cr2w, this);
				}
				return _numAllMainPoses;
			}
			set
			{
				if (_numAllMainPoses == value)
				{
					return;
				}
				_numAllMainPoses = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("numAllMainPosesInbetweens")] 
		public CUInt16 NumAllMainPosesInbetweens
		{
			get
			{
				if (_numAllMainPosesInbetweens == null)
				{
					_numAllMainPosesInbetweens = (CUInt16) CR2WTypeManager.Create("Uint16", "numAllMainPosesInbetweens", cr2w, this);
				}
				return _numAllMainPosesInbetweens;
			}
			set
			{
				if (_numAllMainPosesInbetweens == value)
				{
					return;
				}
				_numAllMainPosesInbetweens = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("numAllMainPosesInbetweenScopeMultipliers")] 
		public CUInt16 NumAllMainPosesInbetweenScopeMultipliers
		{
			get
			{
				if (_numAllMainPosesInbetweenScopeMultipliers == null)
				{
					_numAllMainPosesInbetweenScopeMultipliers = (CUInt16) CR2WTypeManager.Create("Uint16", "numAllMainPosesInbetweenScopeMultipliers", cr2w, this);
				}
				return _numAllMainPosesInbetweenScopeMultipliers;
			}
			set
			{
				if (_numAllMainPosesInbetweenScopeMultipliers == value)
				{
					return;
				}
				_numAllMainPosesInbetweenScopeMultipliers = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("numEnvelopesPerTrackMapping")] 
		public CUInt16 NumEnvelopesPerTrackMapping
		{
			get
			{
				if (_numEnvelopesPerTrackMapping == null)
				{
					_numEnvelopesPerTrackMapping = (CUInt16) CR2WTypeManager.Create("Uint16", "numEnvelopesPerTrackMapping", cr2w, this);
				}
				return _numEnvelopesPerTrackMapping;
			}
			set
			{
				if (_numEnvelopesPerTrackMapping == value)
				{
					return;
				}
				_numEnvelopesPerTrackMapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("wrinkleStartingIndex")] 
		public CUInt16 WrinkleStartingIndex
		{
			get
			{
				if (_wrinkleStartingIndex == null)
				{
					_wrinkleStartingIndex = (CUInt16) CR2WTypeManager.Create("Uint16", "wrinkleStartingIndex", cr2w, this);
				}
				return _wrinkleStartingIndex;
			}
			set
			{
				if (_wrinkleStartingIndex == value)
				{
					return;
				}
				_wrinkleStartingIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("numWrinkles")] 
		public CUInt16 NumWrinkles
		{
			get
			{
				if (_numWrinkles == null)
				{
					_numWrinkles = (CUInt16) CR2WTypeManager.Create("Uint16", "numWrinkles", cr2w, this);
				}
				return _numWrinkles;
			}
			set
			{
				if (_numWrinkles == value)
				{
					return;
				}
				_numWrinkles = value;
				PropertySet(this);
			}
		}

		public animFacialSetup_OneSermoBufferInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
