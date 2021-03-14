using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questvehicleRacingParams : questVehicleSpecificCommandParams
	{
		private NodeRef _splineRef;
		private CFloat _preciseLevel;
		private CBool _reverseSpline;
		private CBool _backwards;
		private CBool _closest;
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
		[RED("preciseLevel")] 
		public CFloat PreciseLevel
		{
			get
			{
				if (_preciseLevel == null)
				{
					_preciseLevel = (CFloat) CR2WTypeManager.Create("Float", "preciseLevel", cr2w, this);
				}
				return _preciseLevel;
			}
			set
			{
				if (_preciseLevel == value)
				{
					return;
				}
				_preciseLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		public questvehicleRacingParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
