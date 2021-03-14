using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GetRandomPositionAroundPoint : AIRandomTasks
	{
		private CHandle<AIArgumentMapping> _originPoint;
		private CHandle<AIArgumentMapping> _distanceMin;
		private CHandle<AIArgumentMapping> _distanceMax;
		private CHandle<AIArgumentMapping> _angleMin;
		private CHandle<AIArgumentMapping> _angleMax;
		private CHandle<AIArgumentMapping> _outPositionArgument;
		private Vector4 _finalPosition;

		[Ordinal(0)] 
		[RED("originPoint")] 
		public CHandle<AIArgumentMapping> OriginPoint
		{
			get
			{
				if (_originPoint == null)
				{
					_originPoint = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "originPoint", cr2w, this);
				}
				return _originPoint;
			}
			set
			{
				if (_originPoint == value)
				{
					return;
				}
				_originPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("distanceMin")] 
		public CHandle<AIArgumentMapping> DistanceMin
		{
			get
			{
				if (_distanceMin == null)
				{
					_distanceMin = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "distanceMin", cr2w, this);
				}
				return _distanceMin;
			}
			set
			{
				if (_distanceMin == value)
				{
					return;
				}
				_distanceMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("distanceMax")] 
		public CHandle<AIArgumentMapping> DistanceMax
		{
			get
			{
				if (_distanceMax == null)
				{
					_distanceMax = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "distanceMax", cr2w, this);
				}
				return _distanceMax;
			}
			set
			{
				if (_distanceMax == value)
				{
					return;
				}
				_distanceMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("angleMin")] 
		public CHandle<AIArgumentMapping> AngleMin
		{
			get
			{
				if (_angleMin == null)
				{
					_angleMin = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "angleMin", cr2w, this);
				}
				return _angleMin;
			}
			set
			{
				if (_angleMin == value)
				{
					return;
				}
				_angleMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("angleMax")] 
		public CHandle<AIArgumentMapping> AngleMax
		{
			get
			{
				if (_angleMax == null)
				{
					_angleMax = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "angleMax", cr2w, this);
				}
				return _angleMax;
			}
			set
			{
				if (_angleMax == value)
				{
					return;
				}
				_angleMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("outPositionArgument")] 
		public CHandle<AIArgumentMapping> OutPositionArgument
		{
			get
			{
				if (_outPositionArgument == null)
				{
					_outPositionArgument = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outPositionArgument", cr2w, this);
				}
				return _outPositionArgument;
			}
			set
			{
				if (_outPositionArgument == value)
				{
					return;
				}
				_outPositionArgument = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("finalPosition")] 
		public Vector4 FinalPosition
		{
			get
			{
				if (_finalPosition == null)
				{
					_finalPosition = (Vector4) CR2WTypeManager.Create("Vector4", "finalPosition", cr2w, this);
				}
				return _finalPosition;
			}
			set
			{
				if (_finalPosition == value)
				{
					return;
				}
				_finalPosition = value;
				PropertySet(this);
			}
		}

		public GetRandomPositionAroundPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
