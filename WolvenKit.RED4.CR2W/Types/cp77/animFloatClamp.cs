using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animFloatClamp : CVariable
	{
		private CBool _useMin;
		private CFloat _min;
		private CBool _useMax;
		private CFloat _max;

		[Ordinal(0)] 
		[RED("useMin")] 
		public CBool UseMin
		{
			get
			{
				if (_useMin == null)
				{
					_useMin = (CBool) CR2WTypeManager.Create("Bool", "useMin", cr2w, this);
				}
				return _useMin;
			}
			set
			{
				if (_useMin == value)
				{
					return;
				}
				_useMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("useMax")] 
		public CBool UseMax
		{
			get
			{
				if (_useMax == null)
				{
					_useMax = (CBool) CR2WTypeManager.Create("Bool", "useMax", cr2w, this);
				}
				return _useMax;
			}
			set
			{
				if (_useMax == value)
				{
					return;
				}
				_useMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public animFloatClamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
