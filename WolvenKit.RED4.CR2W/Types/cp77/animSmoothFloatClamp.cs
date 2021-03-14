using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSmoothFloatClamp : CVariable
	{
		private CFloat _min;
		private CFloat _max;
		private curveData<CFloat> _marginEaseOutCurve;

		[Ordinal(0)] 
		[RED("min")] 
		public CFloat Min
		{
			get
			{
				if (_min == null)
				{
					_min = (CFloat) CR2WTypeManager.Create("Float", "min", cr2w, this);
				}
				return _min;
			}
			set
			{
				if (_min == value)
				{
					return;
				}
				_min = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("max")] 
		public CFloat Max
		{
			get
			{
				if (_max == null)
				{
					_max = (CFloat) CR2WTypeManager.Create("Float", "max", cr2w, this);
				}
				return _max;
			}
			set
			{
				if (_max == value)
				{
					return;
				}
				_max = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("marginEaseOutCurve")] 
		public curveData<CFloat> MarginEaseOutCurve
		{
			get
			{
				if (_marginEaseOutCurve == null)
				{
					_marginEaseOutCurve = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "marginEaseOutCurve", cr2w, this);
				}
				return _marginEaseOutCurve;
			}
			set
			{
				if (_marginEaseOutCurve == value)
				{
					return;
				}
				_marginEaseOutCurve = value;
				PropertySet(this);
			}
		}

		public animSmoothFloatClamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
