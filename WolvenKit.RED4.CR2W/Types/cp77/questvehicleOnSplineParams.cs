using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questvehicleOnSplineParams : questVehicleSpecificCommandParams
	{
		private NodeRef _splineRef;
		private CBool _reverseSpline;
		private CBool _backwards;
		private CBool _closest;
		private CFloat _forcedStartSpeed;
		private CBool _stopAtEnd;
		private CBool _keepDistance;
		private CHandle<questParamKeepDistance> _keepDistanceParam;
		private CBool _rubberBanding;
		private CHandle<questParamRubberbanding> _rubberBandingParam;

		[Ordinal(3)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get
			{
				if (_splineRef == null)
				{
					_splineRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "splineRef", cr2w, this);
				}
				return _splineRef;
			}
			set
			{
				if (_splineRef == value)
				{
					return;
				}
				_splineRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("reverseSpline")] 
		public CBool ReverseSpline
		{
			get
			{
				if (_reverseSpline == null)
				{
					_reverseSpline = (CBool) CR2WTypeManager.Create("Bool", "reverseSpline", cr2w, this);
				}
				return _reverseSpline;
			}
			set
			{
				if (_reverseSpline == value)
				{
					return;
				}
				_reverseSpline = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("backwards")] 
		public CBool Backwards
		{
			get
			{
				if (_backwards == null)
				{
					_backwards = (CBool) CR2WTypeManager.Create("Bool", "backwards", cr2w, this);
				}
				return _backwards;
			}
			set
			{
				if (_backwards == value)
				{
					return;
				}
				_backwards = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("closest")] 
		public CBool Closest
		{
			get
			{
				if (_closest == null)
				{
					_closest = (CBool) CR2WTypeManager.Create("Bool", "closest", cr2w, this);
				}
				return _closest;
			}
			set
			{
				if (_closest == value)
				{
					return;
				}
				_closest = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("forcedStartSpeed")] 
		public CFloat ForcedStartSpeed
		{
			get
			{
				if (_forcedStartSpeed == null)
				{
					_forcedStartSpeed = (CFloat) CR2WTypeManager.Create("Float", "forcedStartSpeed", cr2w, this);
				}
				return _forcedStartSpeed;
			}
			set
			{
				if (_forcedStartSpeed == value)
				{
					return;
				}
				_forcedStartSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("stopAtEnd")] 
		public CBool StopAtEnd
		{
			get
			{
				if (_stopAtEnd == null)
				{
					_stopAtEnd = (CBool) CR2WTypeManager.Create("Bool", "stopAtEnd", cr2w, this);
				}
				return _stopAtEnd;
			}
			set
			{
				if (_stopAtEnd == value)
				{
					return;
				}
				_stopAtEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("keepDistance")] 
		public CBool KeepDistance
		{
			get
			{
				if (_keepDistance == null)
				{
					_keepDistance = (CBool) CR2WTypeManager.Create("Bool", "keepDistance", cr2w, this);
				}
				return _keepDistance;
			}
			set
			{
				if (_keepDistance == value)
				{
					return;
				}
				_keepDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("keepDistanceParam")] 
		public CHandle<questParamKeepDistance> KeepDistanceParam
		{
			get
			{
				if (_keepDistanceParam == null)
				{
					_keepDistanceParam = (CHandle<questParamKeepDistance>) CR2WTypeManager.Create("handle:questParamKeepDistance", "keepDistanceParam", cr2w, this);
				}
				return _keepDistanceParam;
			}
			set
			{
				if (_keepDistanceParam == value)
				{
					return;
				}
				_keepDistanceParam = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("rubberBanding")] 
		public CBool RubberBanding
		{
			get
			{
				if (_rubberBanding == null)
				{
					_rubberBanding = (CBool) CR2WTypeManager.Create("Bool", "rubberBanding", cr2w, this);
				}
				return _rubberBanding;
			}
			set
			{
				if (_rubberBanding == value)
				{
					return;
				}
				_rubberBanding = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("rubberBandingParam")] 
		public CHandle<questParamRubberbanding> RubberBandingParam
		{
			get
			{
				if (_rubberBandingParam == null)
				{
					_rubberBandingParam = (CHandle<questParamRubberbanding>) CR2WTypeManager.Create("handle:questParamRubberbanding", "rubberBandingParam", cr2w, this);
				}
				return _rubberBandingParam;
			}
			set
			{
				if (_rubberBandingParam == value)
				{
					return;
				}
				_rubberBandingParam = value;
				PropertySet(this);
			}
		}

		public questvehicleOnSplineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
