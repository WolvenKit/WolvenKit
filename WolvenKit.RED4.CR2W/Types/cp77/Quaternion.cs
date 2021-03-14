using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Quaternion : CVariable
	{
		private CFloat _i;
		private CFloat _j;
		private CFloat _k;
		private CFloat _r;

		[Ordinal(0)] 
		[RED("i")] 
		public CFloat I
		{
			get
			{
				if (_i == null)
				{
					_i = (CFloat) CR2WTypeManager.Create("Float", "i", cr2w, this);
				}
				return _i;
			}
			set
			{
				if (_i == value)
				{
					return;
				}
				_i = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("j")] 
		public CFloat J
		{
			get
			{
				if (_j == null)
				{
					_j = (CFloat) CR2WTypeManager.Create("Float", "j", cr2w, this);
				}
				return _j;
			}
			set
			{
				if (_j == value)
				{
					return;
				}
				_j = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("k")] 
		public CFloat K
		{
			get
			{
				if (_k == null)
				{
					_k = (CFloat) CR2WTypeManager.Create("Float", "k", cr2w, this);
				}
				return _k;
			}
			set
			{
				if (_k == value)
				{
					return;
				}
				_k = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("r")] 
		public CFloat R
		{
			get
			{
				if (_r == null)
				{
					_r = (CFloat) CR2WTypeManager.Create("Float", "r", cr2w, this);
				}
				return _r;
			}
			set
			{
				if (_r == value)
				{
					return;
				}
				_r = value;
				PropertySet(this);
			}
		}

		public Quaternion(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
