using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animImportFacialCorrectivePoseDesc : CVariable
	{
		private CArray<CName> _influencedBy;
		private CArray<CUInt16> _influenceMainWeightIndices;
		private CArray<animImportFacialCorrectivePoseDataDesc> _poses;
		private CArray<CInt16> _parentsInBetweenIndices;
		private CArray<CUInt16> _parentIndices;
		private CName _name;
		private CUInt16 _index;
		private CUInt8 _influencedBySpeed;
		private CUInt8 _poseType;
		private CUInt8 _poseLOD;
		private CArray<CFloat> _weights;
		private CArray<CFloat> _inBetweenScopeMultipliers;
		private CBool _linearCorrection;
		private CBool _useGlobalWeight;

		[Ordinal(0)] 
		[RED("influencedBy")] 
		public CArray<CName> InfluencedBy
		{
			get
			{
				if (_influencedBy == null)
				{
					_influencedBy = (CArray<CName>) CR2WTypeManager.Create("array:CName", "influencedBy", cr2w, this);
				}
				return _influencedBy;
			}
			set
			{
				if (_influencedBy == value)
				{
					return;
				}
				_influencedBy = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("influenceMainWeightIndices")] 
		public CArray<CUInt16> InfluenceMainWeightIndices
		{
			get
			{
				if (_influenceMainWeightIndices == null)
				{
					_influenceMainWeightIndices = (CArray<CUInt16>) CR2WTypeManager.Create("array:Uint16", "influenceMainWeightIndices", cr2w, this);
				}
				return _influenceMainWeightIndices;
			}
			set
			{
				if (_influenceMainWeightIndices == value)
				{
					return;
				}
				_influenceMainWeightIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("poses")] 
		public CArray<animImportFacialCorrectivePoseDataDesc> Poses
		{
			get
			{
				if (_poses == null)
				{
					_poses = (CArray<animImportFacialCorrectivePoseDataDesc>) CR2WTypeManager.Create("array:animImportFacialCorrectivePoseDataDesc", "poses", cr2w, this);
				}
				return _poses;
			}
			set
			{
				if (_poses == value)
				{
					return;
				}
				_poses = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("parentsInBetweenIndices")] 
		public CArray<CInt16> ParentsInBetweenIndices
		{
			get
			{
				if (_parentsInBetweenIndices == null)
				{
					_parentsInBetweenIndices = (CArray<CInt16>) CR2WTypeManager.Create("array:Int16", "parentsInBetweenIndices", cr2w, this);
				}
				return _parentsInBetweenIndices;
			}
			set
			{
				if (_parentsInBetweenIndices == value)
				{
					return;
				}
				_parentsInBetweenIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("parentIndices")] 
		public CArray<CUInt16> ParentIndices
		{
			get
			{
				if (_parentIndices == null)
				{
					_parentIndices = (CArray<CUInt16>) CR2WTypeManager.Create("array:Uint16", "parentIndices", cr2w, this);
				}
				return _parentIndices;
			}
			set
			{
				if (_parentIndices == value)
				{
					return;
				}
				_parentIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("index")] 
		public CUInt16 Index
		{
			get
			{
				if (_index == null)
				{
					_index = (CUInt16) CR2WTypeManager.Create("Uint16", "index", cr2w, this);
				}
				return _index;
			}
			set
			{
				if (_index == value)
				{
					return;
				}
				_index = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("influencedBySpeed")] 
		public CUInt8 InfluencedBySpeed
		{
			get
			{
				if (_influencedBySpeed == null)
				{
					_influencedBySpeed = (CUInt8) CR2WTypeManager.Create("Uint8", "influencedBySpeed", cr2w, this);
				}
				return _influencedBySpeed;
			}
			set
			{
				if (_influencedBySpeed == value)
				{
					return;
				}
				_influencedBySpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("poseType")] 
		public CUInt8 PoseType
		{
			get
			{
				if (_poseType == null)
				{
					_poseType = (CUInt8) CR2WTypeManager.Create("Uint8", "poseType", cr2w, this);
				}
				return _poseType;
			}
			set
			{
				if (_poseType == value)
				{
					return;
				}
				_poseType = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("poseLOD")] 
		public CUInt8 PoseLOD
		{
			get
			{
				if (_poseLOD == null)
				{
					_poseLOD = (CUInt8) CR2WTypeManager.Create("Uint8", "poseLOD", cr2w, this);
				}
				return _poseLOD;
			}
			set
			{
				if (_poseLOD == value)
				{
					return;
				}
				_poseLOD = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("weights")] 
		public CArray<CFloat> Weights
		{
			get
			{
				if (_weights == null)
				{
					_weights = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "weights", cr2w, this);
				}
				return _weights;
			}
			set
			{
				if (_weights == value)
				{
					return;
				}
				_weights = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("inBetweenScopeMultipliers")] 
		public CArray<CFloat> InBetweenScopeMultipliers
		{
			get
			{
				if (_inBetweenScopeMultipliers == null)
				{
					_inBetweenScopeMultipliers = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "inBetweenScopeMultipliers", cr2w, this);
				}
				return _inBetweenScopeMultipliers;
			}
			set
			{
				if (_inBetweenScopeMultipliers == value)
				{
					return;
				}
				_inBetweenScopeMultipliers = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("linearCorrection")] 
		public CBool LinearCorrection
		{
			get
			{
				if (_linearCorrection == null)
				{
					_linearCorrection = (CBool) CR2WTypeManager.Create("Bool", "linearCorrection", cr2w, this);
				}
				return _linearCorrection;
			}
			set
			{
				if (_linearCorrection == value)
				{
					return;
				}
				_linearCorrection = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("useGlobalWeight")] 
		public CBool UseGlobalWeight
		{
			get
			{
				if (_useGlobalWeight == null)
				{
					_useGlobalWeight = (CBool) CR2WTypeManager.Create("Bool", "useGlobalWeight", cr2w, this);
				}
				return _useGlobalWeight;
			}
			set
			{
				if (_useGlobalWeight == value)
				{
					return;
				}
				_useGlobalWeight = value;
				PropertySet(this);
			}
		}

		public animImportFacialCorrectivePoseDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
