using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HasPositionFarFromThreat : AIbehaviorconditionScript
	{
		private CFloat _desiredDistance;
		private CFloat _minDistance;
		private CFloat _minPathLength;
		private CFloat _distanceFromTraffic;

		[Ordinal(0)] 
		[RED("desiredDistance")] 
		public CFloat DesiredDistance
		{
			get
			{
				if (_desiredDistance == null)
				{
					_desiredDistance = (CFloat) CR2WTypeManager.Create("Float", "desiredDistance", cr2w, this);
				}
				return _desiredDistance;
			}
			set
			{
				if (_desiredDistance == value)
				{
					return;
				}
				_desiredDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get
			{
				if (_minDistance == null)
				{
					_minDistance = (CFloat) CR2WTypeManager.Create("Float", "minDistance", cr2w, this);
				}
				return _minDistance;
			}
			set
			{
				if (_minDistance == value)
				{
					return;
				}
				_minDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("minPathLength")] 
		public CFloat MinPathLength
		{
			get
			{
				if (_minPathLength == null)
				{
					_minPathLength = (CFloat) CR2WTypeManager.Create("Float", "minPathLength", cr2w, this);
				}
				return _minPathLength;
			}
			set
			{
				if (_minPathLength == value)
				{
					return;
				}
				_minPathLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("distanceFromTraffic")] 
		public CFloat DistanceFromTraffic
		{
			get
			{
				if (_distanceFromTraffic == null)
				{
					_distanceFromTraffic = (CFloat) CR2WTypeManager.Create("Float", "distanceFromTraffic", cr2w, this);
				}
				return _distanceFromTraffic;
			}
			set
			{
				if (_distanceFromTraffic == value)
				{
					return;
				}
				_distanceFromTraffic = value;
				PropertySet(this);
			}
		}

		public HasPositionFarFromThreat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
