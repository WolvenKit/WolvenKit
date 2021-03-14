using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFindPositionAroundSelf : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _distanceMin;
		private CHandle<AIArgumentMapping> _distanceMax;
		private CFloat _angle;
		private CFloat _angleOffset;
		private CHandle<AIArgumentMapping> _outPositionArgument;
		private Vector4 _finalPosition;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("angle")] 
		public CFloat Angle
		{
			get
			{
				if (_angle == null)
				{
					_angle = (CFloat) CR2WTypeManager.Create("Float", "angle", cr2w, this);
				}
				return _angle;
			}
			set
			{
				if (_angle == value)
				{
					return;
				}
				_angle = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("angleOffset")] 
		public CFloat AngleOffset
		{
			get
			{
				if (_angleOffset == null)
				{
					_angleOffset = (CFloat) CR2WTypeManager.Create("Float", "angleOffset", cr2w, this);
				}
				return _angleOffset;
			}
			set
			{
				if (_angleOffset == value)
				{
					return;
				}
				_angleOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		public AIFindPositionAroundSelf(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
