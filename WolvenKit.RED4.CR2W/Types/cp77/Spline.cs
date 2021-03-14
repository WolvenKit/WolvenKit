using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Spline : ISerializable
	{
		private CArray<SplinePoint> _points;
		private CBool _looped;
		private CBool _reversed;
		private CBool _hasDirection;

		[Ordinal(0)] 
		[RED("points")] 
		public CArray<SplinePoint> Points
		{
			get
			{
				if (_points == null)
				{
					_points = (CArray<SplinePoint>) CR2WTypeManager.Create("array:SplinePoint", "points", cr2w, this);
				}
				return _points;
			}
			set
			{
				if (_points == value)
				{
					return;
				}
				_points = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("looped")] 
		public CBool Looped
		{
			get
			{
				if (_looped == null)
				{
					_looped = (CBool) CR2WTypeManager.Create("Bool", "looped", cr2w, this);
				}
				return _looped;
			}
			set
			{
				if (_looped == value)
				{
					return;
				}
				_looped = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("reversed")] 
		public CBool Reversed
		{
			get
			{
				if (_reversed == null)
				{
					_reversed = (CBool) CR2WTypeManager.Create("Bool", "reversed", cr2w, this);
				}
				return _reversed;
			}
			set
			{
				if (_reversed == value)
				{
					return;
				}
				_reversed = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hasDirection")] 
		public CBool HasDirection
		{
			get
			{
				if (_hasDirection == null)
				{
					_hasDirection = (CBool) CR2WTypeManager.Create("Bool", "hasDirection", cr2w, this);
				}
				return _hasDirection;
			}
			set
			{
				if (_hasDirection == value)
				{
					return;
				}
				_hasDirection = value;
				PropertySet(this);
			}
		}

		public Spline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
