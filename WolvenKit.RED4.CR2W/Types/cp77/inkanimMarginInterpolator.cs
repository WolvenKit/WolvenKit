using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimMarginInterpolator : inkanimInterpolator
	{
		private inkMargin _startValue;
		private inkMargin _endValue;

		[Ordinal(7)] 
		[RED("startValue")] 
		public inkMargin StartValue
		{
			get
			{
				if (_startValue == null)
				{
					_startValue = (inkMargin) CR2WTypeManager.Create("inkMargin", "startValue", cr2w, this);
				}
				return _startValue;
			}
			set
			{
				if (_startValue == value)
				{
					return;
				}
				_startValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("endValue")] 
		public inkMargin EndValue
		{
			get
			{
				if (_endValue == null)
				{
					_endValue = (inkMargin) CR2WTypeManager.Create("inkMargin", "endValue", cr2w, this);
				}
				return _endValue;
			}
			set
			{
				if (_endValue == value)
				{
					return;
				}
				_endValue = value;
				PropertySet(this);
			}
		}

		public inkanimMarginInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
