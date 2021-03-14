using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameRicochetData : CVariable
	{
		private CInt32 _count;
		private CFloat _range;
		private CFloat _targetSearchAngle;
		private CFloat _minAngle;
		private CFloat _maxAngle;
		private CFloat _chance;

		[Ordinal(0)] 
		[RED("count")] 
		public CInt32 Count
		{
			get
			{
				if (_count == null)
				{
					_count = (CInt32) CR2WTypeManager.Create("Int32", "count", cr2w, this);
				}
				return _count;
			}
			set
			{
				if (_count == value)
				{
					return;
				}
				_count = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("range")] 
		public CFloat Range
		{
			get
			{
				if (_range == null)
				{
					_range = (CFloat) CR2WTypeManager.Create("Float", "range", cr2w, this);
				}
				return _range;
			}
			set
			{
				if (_range == value)
				{
					return;
				}
				_range = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetSearchAngle")] 
		public CFloat TargetSearchAngle
		{
			get
			{
				if (_targetSearchAngle == null)
				{
					_targetSearchAngle = (CFloat) CR2WTypeManager.Create("Float", "targetSearchAngle", cr2w, this);
				}
				return _targetSearchAngle;
			}
			set
			{
				if (_targetSearchAngle == value)
				{
					return;
				}
				_targetSearchAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("minAngle")] 
		public CFloat MinAngle
		{
			get
			{
				if (_minAngle == null)
				{
					_minAngle = (CFloat) CR2WTypeManager.Create("Float", "minAngle", cr2w, this);
				}
				return _minAngle;
			}
			set
			{
				if (_minAngle == value)
				{
					return;
				}
				_minAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maxAngle")] 
		public CFloat MaxAngle
		{
			get
			{
				if (_maxAngle == null)
				{
					_maxAngle = (CFloat) CR2WTypeManager.Create("Float", "maxAngle", cr2w, this);
				}
				return _maxAngle;
			}
			set
			{
				if (_maxAngle == value)
				{
					return;
				}
				_maxAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("chance")] 
		public CFloat Chance
		{
			get
			{
				if (_chance == null)
				{
					_chance = (CFloat) CR2WTypeManager.Create("Float", "chance", cr2w, this);
				}
				return _chance;
			}
			set
			{
				if (_chance == value)
				{
					return;
				}
				_chance = value;
				PropertySet(this);
			}
		}

		public gameRicochetData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
