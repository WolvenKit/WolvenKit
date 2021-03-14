using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimShearInterpolator : inkanimInterpolator
	{
		private Vector2 _startValue;
		private Vector2 _endValue;

		[Ordinal(7)] 
		[RED("startValue")] 
		public Vector2 StartValue
		{
			get
			{
				if (_startValue == null)
				{
					_startValue = (Vector2) CR2WTypeManager.Create("Vector2", "startValue", cr2w, this);
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
		public Vector2 EndValue
		{
			get
			{
				if (_endValue == null)
				{
					_endValue = (Vector2) CR2WTypeManager.Create("Vector2", "endValue", cr2w, this);
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

		public inkanimShearInterpolator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
