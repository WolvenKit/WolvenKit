using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Box : CVariable
	{
		private Vector4 _min;
		private Vector4 _max;

		[Ordinal(0)] 
		[RED("Min")] 
		public Vector4 Min
		{
			get
			{
				if (_min == null)
				{
					_min = (Vector4) CR2WTypeManager.Create("Vector4", "Min", cr2w, this);
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
		[RED("Max")] 
		public Vector4 Max
		{
			get
			{
				if (_max == null)
				{
					_max = (Vector4) CR2WTypeManager.Create("Vector4", "Max", cr2w, this);
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

		public Box(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
