using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimColorInterpolator : inkanimInterpolator
	{
		private HDRColor _startValue;
		private HDRColor _endValue;

		[Ordinal(7)] 
		[RED("startValue")] 
		public HDRColor StartValue
		{
			get
			{
				if (_startValue == null)
				{
					_startValue = (HDRColor) CR2WTypeManager.Create("HDRColor", "startValue", cr2w, this);
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
		public HDRColor EndValue
		{
			get
			{
				if (_endValue == null)
				{
					_endValue = (HDRColor) CR2WTypeManager.Create("HDRColor", "endValue", cr2w, this);
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

		public inkanimColorInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
