using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animImportFacialSetupDesc : CVariable
	{
		private CArray<animImportFacialInitialPoseEntryDesc> _initialPose;
		private animImportFacialInitialControlsDesc _initialControls;
		private CArray<animImportFacialMainPoseDesc> _mainPoses;
		private CArray<animSermoPoseInfo> _mainPosesInfo;
		private CArray<CInt16> _jawAreaTrackIndices;
		private CArray<CInt16> _lipsAreaTrackIndices;
		private CArray<CInt16> _eyesAreaTrackIndices;
		private CUInt16 _numCachedPoseTracks;
		private CArray<animImportFacialCorrectivePoseDesc> _correctivePoses;
		private CArray<animPoseLimitWeights> _globalPoseLimits;
		private CUInt16 _wrinkleStartingIndex;
		private CArray<CUInt16> _wrinkleMapping;

		[Ordinal(0)] 
		[RED("initialPose")] 
		public CArray<animImportFacialInitialPoseEntryDesc> InitialPose
		{
			get
			{
				if (_initialPose == null)
				{
					_initialPose = (CArray<animImportFacialInitialPoseEntryDesc>) CR2WTypeManager.Create("array:animImportFacialInitialPoseEntryDesc", "initialPose", cr2w, this);
				}
				return _initialPose;
			}
			set
			{
				if (_initialPose == value)
				{
					return;
				}
				_initialPose = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("initialControls")] 
		public animImportFacialInitialControlsDesc InitialControls
		{
			get
			{
				if (_initialControls == null)
				{
					_initialControls = (animImportFacialInitialControlsDesc) CR2WTypeManager.Create("animImportFacialInitialControlsDesc", "initialControls", cr2w, this);
				}
				return _initialControls;
			}
			set
			{
				if (_initialControls == value)
				{
					return;
				}
				_initialControls = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("mainPoses")] 
		public CArray<animImportFacialMainPoseDesc> MainPoses
		{
			get
			{
				if (_mainPoses == null)
				{
					_mainPoses = (CArray<animImportFacialMainPoseDesc>) CR2WTypeManager.Create("array:animImportFacialMainPoseDesc", "mainPoses", cr2w, this);
				}
				return _mainPoses;
			}
			set
			{
				if (_mainPoses == value)
				{
					return;
				}
				_mainPoses = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("mainPosesInfo")] 
		public CArray<animSermoPoseInfo> MainPosesInfo
		{
			get
			{
				if (_mainPosesInfo == null)
				{
					_mainPosesInfo = (CArray<animSermoPoseInfo>) CR2WTypeManager.Create("array:animSermoPoseInfo", "mainPosesInfo", cr2w, this);
				}
				return _mainPosesInfo;
			}
			set
			{
				if (_mainPosesInfo == value)
				{
					return;
				}
				_mainPosesInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("jawAreaTrackIndices")] 
		public CArray<CInt16> JawAreaTrackIndices
		{
			get
			{
				if (_jawAreaTrackIndices == null)
				{
					_jawAreaTrackIndices = (CArray<CInt16>) CR2WTypeManager.Create("array:Int16", "jawAreaTrackIndices", cr2w, this);
				}
				return _jawAreaTrackIndices;
			}
			set
			{
				if (_jawAreaTrackIndices == value)
				{
					return;
				}
				_jawAreaTrackIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("lipsAreaTrackIndices")] 
		public CArray<CInt16> LipsAreaTrackIndices
		{
			get
			{
				if (_lipsAreaTrackIndices == null)
				{
					_lipsAreaTrackIndices = (CArray<CInt16>) CR2WTypeManager.Create("array:Int16", "lipsAreaTrackIndices", cr2w, this);
				}
				return _lipsAreaTrackIndices;
			}
			set
			{
				if (_lipsAreaTrackIndices == value)
				{
					return;
				}
				_lipsAreaTrackIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("eyesAreaTrackIndices")] 
		public CArray<CInt16> EyesAreaTrackIndices
		{
			get
			{
				if (_eyesAreaTrackIndices == null)
				{
					_eyesAreaTrackIndices = (CArray<CInt16>) CR2WTypeManager.Create("array:Int16", "eyesAreaTrackIndices", cr2w, this);
				}
				return _eyesAreaTrackIndices;
			}
			set
			{
				if (_eyesAreaTrackIndices == value)
				{
					return;
				}
				_eyesAreaTrackIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("numCachedPoseTracks")] 
		public CUInt16 NumCachedPoseTracks
		{
			get
			{
				if (_numCachedPoseTracks == null)
				{
					_numCachedPoseTracks = (CUInt16) CR2WTypeManager.Create("Uint16", "numCachedPoseTracks", cr2w, this);
				}
				return _numCachedPoseTracks;
			}
			set
			{
				if (_numCachedPoseTracks == value)
				{
					return;
				}
				_numCachedPoseTracks = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("correctivePoses")] 
		public CArray<animImportFacialCorrectivePoseDesc> CorrectivePoses
		{
			get
			{
				if (_correctivePoses == null)
				{
					_correctivePoses = (CArray<animImportFacialCorrectivePoseDesc>) CR2WTypeManager.Create("array:animImportFacialCorrectivePoseDesc", "correctivePoses", cr2w, this);
				}
				return _correctivePoses;
			}
			set
			{
				if (_correctivePoses == value)
				{
					return;
				}
				_correctivePoses = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("globalPoseLimits")] 
		public CArray<animPoseLimitWeights> GlobalPoseLimits
		{
			get
			{
				if (_globalPoseLimits == null)
				{
					_globalPoseLimits = (CArray<animPoseLimitWeights>) CR2WTypeManager.Create("array:animPoseLimitWeights", "globalPoseLimits", cr2w, this);
				}
				return _globalPoseLimits;
			}
			set
			{
				if (_globalPoseLimits == value)
				{
					return;
				}
				_globalPoseLimits = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("wrinkleMapping")] 
		public CArray<CUInt16> WrinkleMapping
		{
			get
			{
				if (_wrinkleMapping == null)
				{
					_wrinkleMapping = (CArray<CUInt16>) CR2WTypeManager.Create("array:Uint16", "wrinkleMapping", cr2w, this);
				}
				return _wrinkleMapping;
			}
			set
			{
				if (_wrinkleMapping == value)
				{
					return;
				}
				_wrinkleMapping = value;
				PropertySet(this);
			}
		}

		public animImportFacialSetupDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
