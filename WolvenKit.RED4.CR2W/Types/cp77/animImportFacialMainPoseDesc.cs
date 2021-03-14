using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animImportFacialMainPoseDesc : CVariable
	{
		private CArray<CName> _influencedBy;
		private CArray<CUInt16> _influenceMainWeightIndices;
		private CArray<animImportFacialPoseDesc> _poses;
		private CArray<CUInt16> _poseIndices;
		private CArray<CFloat> _weights;
		private CArray<CFloat> _inBetweenScopeMultipliers;
		private CName _name;
		private CUInt16 _index;
		private CUInt8 _influenceType;
		private CUInt8 _side;
		private CUInt8 _facePart;

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
		public CArray<animImportFacialPoseDesc> Poses
		{
			get
			{
				if (_poses == null)
				{
					_poses = (CArray<animImportFacialPoseDesc>) CR2WTypeManager.Create("array:animImportFacialPoseDesc", "poses", cr2w, this);
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
		[RED("poseIndices")] 
		public CArray<CUInt16> PoseIndices
		{
			get
			{
				if (_poseIndices == null)
				{
					_poseIndices = (CArray<CUInt16>) CR2WTypeManager.Create("array:Uint16", "poseIndices", cr2w, this);
				}
				return _poseIndices;
			}
			set
			{
				if (_poseIndices == value)
				{
					return;
				}
				_poseIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("influenceType")] 
		public CUInt8 InfluenceType
		{
			get
			{
				if (_influenceType == null)
				{
					_influenceType = (CUInt8) CR2WTypeManager.Create("Uint8", "influenceType", cr2w, this);
				}
				return _influenceType;
			}
			set
			{
				if (_influenceType == value)
				{
					return;
				}
				_influenceType = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("side")] 
		public CUInt8 Side
		{
			get
			{
				if (_side == null)
				{
					_side = (CUInt8) CR2WTypeManager.Create("Uint8", "side", cr2w, this);
				}
				return _side;
			}
			set
			{
				if (_side == value)
				{
					return;
				}
				_side = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("facePart")] 
		public CUInt8 FacePart
		{
			get
			{
				if (_facePart == null)
				{
					_facePart = (CUInt8) CR2WTypeManager.Create("Uint8", "facePart", cr2w, this);
				}
				return _facePart;
			}
			set
			{
				if (_facePart == value)
				{
					return;
				}
				_facePart = value;
				PropertySet(this);
			}
		}

		public animImportFacialMainPoseDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
