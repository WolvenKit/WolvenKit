using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animFacialCustomizationSet : CResource
	{
		private rRef<animFacialSetup> _baseSetup;
		private CArray<raRef<animFacialSetup>> _targetSetups;
		private CArray<animFacialCustomizationTargetEntryTemp> _targetSetupsTemp;
		private CUInt32 _numTargets;
		private animFacialSetup_PosesBufferInfo _posesInfo;
		private CArray<CUInt8> _jointRegions;
		private DataBuffer _mainPosesData;
		private CArray<CUInt16> _usedTransformIndices;
		private DataBuffer _correctivePosesData;
		private CUInt32 _numJoints;
		private DataBuffer _rigReferencePosesData;
		private CBool _isCooked;

		[Ordinal(1)] 
		[RED("baseSetup")] 
		public rRef<animFacialSetup> BaseSetup
		{
			get
			{
				if (_baseSetup == null)
				{
					_baseSetup = (rRef<animFacialSetup>) CR2WTypeManager.Create("rRef:animFacialSetup", "baseSetup", cr2w, this);
				}
				return _baseSetup;
			}
			set
			{
				if (_baseSetup == value)
				{
					return;
				}
				_baseSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetSetups")] 
		public CArray<raRef<animFacialSetup>> TargetSetups
		{
			get
			{
				if (_targetSetups == null)
				{
					_targetSetups = (CArray<raRef<animFacialSetup>>) CR2WTypeManager.Create("array:raRef:animFacialSetup", "targetSetups", cr2w, this);
				}
				return _targetSetups;
			}
			set
			{
				if (_targetSetups == value)
				{
					return;
				}
				_targetSetups = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("targetSetupsTemp")] 
		public CArray<animFacialCustomizationTargetEntryTemp> TargetSetupsTemp
		{
			get
			{
				if (_targetSetupsTemp == null)
				{
					_targetSetupsTemp = (CArray<animFacialCustomizationTargetEntryTemp>) CR2WTypeManager.Create("array:animFacialCustomizationTargetEntryTemp", "targetSetupsTemp", cr2w, this);
				}
				return _targetSetupsTemp;
			}
			set
			{
				if (_targetSetupsTemp == value)
				{
					return;
				}
				_targetSetupsTemp = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("numTargets")] 
		public CUInt32 NumTargets
		{
			get
			{
				if (_numTargets == null)
				{
					_numTargets = (CUInt32) CR2WTypeManager.Create("Uint32", "numTargets", cr2w, this);
				}
				return _numTargets;
			}
			set
			{
				if (_numTargets == value)
				{
					return;
				}
				_numTargets = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("posesInfo")] 
		public animFacialSetup_PosesBufferInfo PosesInfo
		{
			get
			{
				if (_posesInfo == null)
				{
					_posesInfo = (animFacialSetup_PosesBufferInfo) CR2WTypeManager.Create("animFacialSetup_PosesBufferInfo", "posesInfo", cr2w, this);
				}
				return _posesInfo;
			}
			set
			{
				if (_posesInfo == value)
				{
					return;
				}
				_posesInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("jointRegions")] 
		public CArray<CUInt8> JointRegions
		{
			get
			{
				if (_jointRegions == null)
				{
					_jointRegions = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "jointRegions", cr2w, this);
				}
				return _jointRegions;
			}
			set
			{
				if (_jointRegions == value)
				{
					return;
				}
				_jointRegions = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("mainPosesData")] 
		public DataBuffer MainPosesData
		{
			get
			{
				if (_mainPosesData == null)
				{
					_mainPosesData = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "mainPosesData", cr2w, this);
				}
				return _mainPosesData;
			}
			set
			{
				if (_mainPosesData == value)
				{
					return;
				}
				_mainPosesData = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("usedTransformIndices")] 
		public CArray<CUInt16> UsedTransformIndices
		{
			get
			{
				if (_usedTransformIndices == null)
				{
					_usedTransformIndices = (CArray<CUInt16>) CR2WTypeManager.Create("array:Uint16", "usedTransformIndices", cr2w, this);
				}
				return _usedTransformIndices;
			}
			set
			{
				if (_usedTransformIndices == value)
				{
					return;
				}
				_usedTransformIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("correctivePosesData")] 
		public DataBuffer CorrectivePosesData
		{
			get
			{
				if (_correctivePosesData == null)
				{
					_correctivePosesData = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "correctivePosesData", cr2w, this);
				}
				return _correctivePosesData;
			}
			set
			{
				if (_correctivePosesData == value)
				{
					return;
				}
				_correctivePosesData = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("numJoints")] 
		public CUInt32 NumJoints
		{
			get
			{
				if (_numJoints == null)
				{
					_numJoints = (CUInt32) CR2WTypeManager.Create("Uint32", "numJoints", cr2w, this);
				}
				return _numJoints;
			}
			set
			{
				if (_numJoints == value)
				{
					return;
				}
				_numJoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("rigReferencePosesData")] 
		public DataBuffer RigReferencePosesData
		{
			get
			{
				if (_rigReferencePosesData == null)
				{
					_rigReferencePosesData = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "rigReferencePosesData", cr2w, this);
				}
				return _rigReferencePosesData;
			}
			set
			{
				if (_rigReferencePosesData == value)
				{
					return;
				}
				_rigReferencePosesData = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isCooked")] 
		public CBool IsCooked
		{
			get
			{
				if (_isCooked == null)
				{
					_isCooked = (CBool) CR2WTypeManager.Create("Bool", "isCooked", cr2w, this);
				}
				return _isCooked;
			}
			set
			{
				if (_isCooked == value)
				{
					return;
				}
				_isCooked = value;
				PropertySet(this);
			}
		}

		public animFacialCustomizationSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
