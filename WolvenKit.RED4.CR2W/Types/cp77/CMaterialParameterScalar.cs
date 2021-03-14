using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterScalar : CMaterialParameter
	{
		private CFloat _scalar;
		private CFloat _min;
		private CFloat _max;

		[Ordinal(2)] 
		[RED("scalar")] 
		public CFloat Scalar
		{
			get
			{
				if (_scalar == null)
				{
					_scalar = (CFloat) CR2WTypeManager.Create("Float", "scalar", cr2w, this);
				}
				return _scalar;
			}
			set
			{
				if (_scalar == value)
				{
					return;
				}
				_scalar = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		public CMaterialParameterScalar(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
