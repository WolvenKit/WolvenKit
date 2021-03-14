using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeDiodeLightSettingsEvent : redEvent
	{
		private CArray<CInt32> _colorValues;
		private CFloat _strength;
		private CFloat _time;
		private CName _curve;
		private CBool _loop;

		[Ordinal(0)] 
		[RED("colorValues")] 
		public CArray<CInt32> ColorValues
		{
			get
			{
				if (_colorValues == null)
				{
					_colorValues = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "colorValues", cr2w, this);
				}
				return _colorValues;
			}
			set
			{
				if (_colorValues == value)
				{
					return;
				}
				_colorValues = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get
			{
				if (_strength == null)
				{
					_strength = (CFloat) CR2WTypeManager.Create("Float", "strength", cr2w, this);
				}
				return _strength;
			}
			set
			{
				if (_strength == value)
				{
					return;
				}
				_strength = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("time")] 
		public CFloat Time
		{
			get
			{
				if (_time == null)
				{
					_time = (CFloat) CR2WTypeManager.Create("Float", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("curve")] 
		public CName Curve
		{
			get
			{
				if (_curve == null)
				{
					_curve = (CName) CR2WTypeManager.Create("CName", "curve", cr2w, this);
				}
				return _curve;
			}
			set
			{
				if (_curve == value)
				{
					return;
				}
				_curve = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("loop")] 
		public CBool Loop
		{
			get
			{
				if (_loop == null)
				{
					_loop = (CBool) CR2WTypeManager.Create("Bool", "loop", cr2w, this);
				}
				return _loop;
			}
			set
			{
				if (_loop == value)
				{
					return;
				}
				_loop = value;
				PropertySet(this);
			}
		}

		public ChangeDiodeLightSettingsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
