using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsDistanceFromScreenCenterPredicate : gameinteractionsIPredicateType
	{
		private CFloat _height;
		private CFloat _width;
		private CFloat _curvature;
		private CFloat _maxPriorityBoundsFactor;

		[Ordinal(0)] 
		[RED("height")] 
		public CFloat Height
		{
			get
			{
				if (_height == null)
				{
					_height = (CFloat) CR2WTypeManager.Create("Float", "height", cr2w, this);
				}
				return _height;
			}
			set
			{
				if (_height == value)
				{
					return;
				}
				_height = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("width")] 
		public CFloat Width
		{
			get
			{
				if (_width == null)
				{
					_width = (CFloat) CR2WTypeManager.Create("Float", "width", cr2w, this);
				}
				return _width;
			}
			set
			{
				if (_width == value)
				{
					return;
				}
				_width = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("curvature")] 
		public CFloat Curvature
		{
			get
			{
				if (_curvature == null)
				{
					_curvature = (CFloat) CR2WTypeManager.Create("Float", "curvature", cr2w, this);
				}
				return _curvature;
			}
			set
			{
				if (_curvature == value)
				{
					return;
				}
				_curvature = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxPriorityBoundsFactor")] 
		public CFloat MaxPriorityBoundsFactor
		{
			get
			{
				if (_maxPriorityBoundsFactor == null)
				{
					_maxPriorityBoundsFactor = (CFloat) CR2WTypeManager.Create("Float", "maxPriorityBoundsFactor", cr2w, this);
				}
				return _maxPriorityBoundsFactor;
			}
			set
			{
				if (_maxPriorityBoundsFactor == value)
				{
					return;
				}
				_maxPriorityBoundsFactor = value;
				PropertySet(this);
			}
		}

		public gameinteractionsDistanceFromScreenCenterPredicate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
