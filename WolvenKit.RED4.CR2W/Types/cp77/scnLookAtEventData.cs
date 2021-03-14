using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnLookAtEventData : CVariable
	{
		private CUInt32 _id;
		private CBool _enable;
		private CName _singleBodyPartName;
		private CName _singleTargetSlot;
		private CName _bodyTargetSlot;
		private CName _headTargetSlot;
		private CName _eyesTargetSlot;
		private CFloat _singleWeight;
		private CFloat _bodyWeight;
		private CFloat _headWeight;
		private CFloat _eyesWeight;
		private CBool _useSingleWeightCurve;
		private CBool _useBodyWeightCurve;
		private CBool _useHeadWeightCurve;
		private CBool _useEyesWeightCurve;
		private curveData<CFloat> _singleWeightCurve;
		private curveData<CFloat> _bodyWeightCurve;
		private curveData<CFloat> _headWeightCurve;
		private curveData<CFloat> _eyesWeightCurve;
		private animLookAtLimits _singleLimits;
		private animLookAtLimits _bodyLimits;
		private animLookAtLimits _headLimits;
		private animLookAtLimits _eyesLimits;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt32) CR2WTypeManager.Create("Uint32", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get
			{
				if (_enable == null)
				{
					_enable = (CBool) CR2WTypeManager.Create("Bool", "enable", cr2w, this);
				}
				return _enable;
			}
			set
			{
				if (_enable == value)
				{
					return;
				}
				_enable = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("singleBodyPartName")] 
		public CName SingleBodyPartName
		{
			get
			{
				if (_singleBodyPartName == null)
				{
					_singleBodyPartName = (CName) CR2WTypeManager.Create("CName", "singleBodyPartName", cr2w, this);
				}
				return _singleBodyPartName;
			}
			set
			{
				if (_singleBodyPartName == value)
				{
					return;
				}
				_singleBodyPartName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("singleTargetSlot")] 
		public CName SingleTargetSlot
		{
			get
			{
				if (_singleTargetSlot == null)
				{
					_singleTargetSlot = (CName) CR2WTypeManager.Create("CName", "singleTargetSlot", cr2w, this);
				}
				return _singleTargetSlot;
			}
			set
			{
				if (_singleTargetSlot == value)
				{
					return;
				}
				_singleTargetSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("bodyTargetSlot")] 
		public CName BodyTargetSlot
		{
			get
			{
				if (_bodyTargetSlot == null)
				{
					_bodyTargetSlot = (CName) CR2WTypeManager.Create("CName", "bodyTargetSlot", cr2w, this);
				}
				return _bodyTargetSlot;
			}
			set
			{
				if (_bodyTargetSlot == value)
				{
					return;
				}
				_bodyTargetSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("headTargetSlot")] 
		public CName HeadTargetSlot
		{
			get
			{
				if (_headTargetSlot == null)
				{
					_headTargetSlot = (CName) CR2WTypeManager.Create("CName", "headTargetSlot", cr2w, this);
				}
				return _headTargetSlot;
			}
			set
			{
				if (_headTargetSlot == value)
				{
					return;
				}
				_headTargetSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("eyesTargetSlot")] 
		public CName EyesTargetSlot
		{
			get
			{
				if (_eyesTargetSlot == null)
				{
					_eyesTargetSlot = (CName) CR2WTypeManager.Create("CName", "eyesTargetSlot", cr2w, this);
				}
				return _eyesTargetSlot;
			}
			set
			{
				if (_eyesTargetSlot == value)
				{
					return;
				}
				_eyesTargetSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("singleWeight")] 
		public CFloat SingleWeight
		{
			get
			{
				if (_singleWeight == null)
				{
					_singleWeight = (CFloat) CR2WTypeManager.Create("Float", "singleWeight", cr2w, this);
				}
				return _singleWeight;
			}
			set
			{
				if (_singleWeight == value)
				{
					return;
				}
				_singleWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("bodyWeight")] 
		public CFloat BodyWeight
		{
			get
			{
				if (_bodyWeight == null)
				{
					_bodyWeight = (CFloat) CR2WTypeManager.Create("Float", "bodyWeight", cr2w, this);
				}
				return _bodyWeight;
			}
			set
			{
				if (_bodyWeight == value)
				{
					return;
				}
				_bodyWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("headWeight")] 
		public CFloat HeadWeight
		{
			get
			{
				if (_headWeight == null)
				{
					_headWeight = (CFloat) CR2WTypeManager.Create("Float", "headWeight", cr2w, this);
				}
				return _headWeight;
			}
			set
			{
				if (_headWeight == value)
				{
					return;
				}
				_headWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("eyesWeight")] 
		public CFloat EyesWeight
		{
			get
			{
				if (_eyesWeight == null)
				{
					_eyesWeight = (CFloat) CR2WTypeManager.Create("Float", "eyesWeight", cr2w, this);
				}
				return _eyesWeight;
			}
			set
			{
				if (_eyesWeight == value)
				{
					return;
				}
				_eyesWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("useSingleWeightCurve")] 
		public CBool UseSingleWeightCurve
		{
			get
			{
				if (_useSingleWeightCurve == null)
				{
					_useSingleWeightCurve = (CBool) CR2WTypeManager.Create("Bool", "useSingleWeightCurve", cr2w, this);
				}
				return _useSingleWeightCurve;
			}
			set
			{
				if (_useSingleWeightCurve == value)
				{
					return;
				}
				_useSingleWeightCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("useBodyWeightCurve")] 
		public CBool UseBodyWeightCurve
		{
			get
			{
				if (_useBodyWeightCurve == null)
				{
					_useBodyWeightCurve = (CBool) CR2WTypeManager.Create("Bool", "useBodyWeightCurve", cr2w, this);
				}
				return _useBodyWeightCurve;
			}
			set
			{
				if (_useBodyWeightCurve == value)
				{
					return;
				}
				_useBodyWeightCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("useHeadWeightCurve")] 
		public CBool UseHeadWeightCurve
		{
			get
			{
				if (_useHeadWeightCurve == null)
				{
					_useHeadWeightCurve = (CBool) CR2WTypeManager.Create("Bool", "useHeadWeightCurve", cr2w, this);
				}
				return _useHeadWeightCurve;
			}
			set
			{
				if (_useHeadWeightCurve == value)
				{
					return;
				}
				_useHeadWeightCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("useEyesWeightCurve")] 
		public CBool UseEyesWeightCurve
		{
			get
			{
				if (_useEyesWeightCurve == null)
				{
					_useEyesWeightCurve = (CBool) CR2WTypeManager.Create("Bool", "useEyesWeightCurve", cr2w, this);
				}
				return _useEyesWeightCurve;
			}
			set
			{
				if (_useEyesWeightCurve == value)
				{
					return;
				}
				_useEyesWeightCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("singleWeightCurve")] 
		public curveData<CFloat> SingleWeightCurve
		{
			get
			{
				if (_singleWeightCurve == null)
				{
					_singleWeightCurve = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "singleWeightCurve", cr2w, this);
				}
				return _singleWeightCurve;
			}
			set
			{
				if (_singleWeightCurve == value)
				{
					return;
				}
				_singleWeightCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("bodyWeightCurve")] 
		public curveData<CFloat> BodyWeightCurve
		{
			get
			{
				if (_bodyWeightCurve == null)
				{
					_bodyWeightCurve = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "bodyWeightCurve", cr2w, this);
				}
				return _bodyWeightCurve;
			}
			set
			{
				if (_bodyWeightCurve == value)
				{
					return;
				}
				_bodyWeightCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("headWeightCurve")] 
		public curveData<CFloat> HeadWeightCurve
		{
			get
			{
				if (_headWeightCurve == null)
				{
					_headWeightCurve = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "headWeightCurve", cr2w, this);
				}
				return _headWeightCurve;
			}
			set
			{
				if (_headWeightCurve == value)
				{
					return;
				}
				_headWeightCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("eyesWeightCurve")] 
		public curveData<CFloat> EyesWeightCurve
		{
			get
			{
				if (_eyesWeightCurve == null)
				{
					_eyesWeightCurve = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "eyesWeightCurve", cr2w, this);
				}
				return _eyesWeightCurve;
			}
			set
			{
				if (_eyesWeightCurve == value)
				{
					return;
				}
				_eyesWeightCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("singleLimits")] 
		public animLookAtLimits SingleLimits
		{
			get
			{
				if (_singleLimits == null)
				{
					_singleLimits = (animLookAtLimits) CR2WTypeManager.Create("animLookAtLimits", "singleLimits", cr2w, this);
				}
				return _singleLimits;
			}
			set
			{
				if (_singleLimits == value)
				{
					return;
				}
				_singleLimits = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("bodyLimits")] 
		public animLookAtLimits BodyLimits
		{
			get
			{
				if (_bodyLimits == null)
				{
					_bodyLimits = (animLookAtLimits) CR2WTypeManager.Create("animLookAtLimits", "bodyLimits", cr2w, this);
				}
				return _bodyLimits;
			}
			set
			{
				if (_bodyLimits == value)
				{
					return;
				}
				_bodyLimits = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("headLimits")] 
		public animLookAtLimits HeadLimits
		{
			get
			{
				if (_headLimits == null)
				{
					_headLimits = (animLookAtLimits) CR2WTypeManager.Create("animLookAtLimits", "headLimits", cr2w, this);
				}
				return _headLimits;
			}
			set
			{
				if (_headLimits == value)
				{
					return;
				}
				_headLimits = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("eyesLimits")] 
		public animLookAtLimits EyesLimits
		{
			get
			{
				if (_eyesLimits == null)
				{
					_eyesLimits = (animLookAtLimits) CR2WTypeManager.Create("animLookAtLimits", "eyesLimits", cr2w, this);
				}
				return _eyesLimits;
			}
			set
			{
				if (_eyesLimits == value)
				{
					return;
				}
				_eyesLimits = value;
				PropertySet(this);
			}
		}

		public scnLookAtEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
