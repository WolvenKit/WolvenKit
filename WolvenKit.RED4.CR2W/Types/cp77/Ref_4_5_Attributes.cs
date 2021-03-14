using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_4_5_Attributes : CVariable
	{
		private CInt32 _i;
		private CFloat _f;
		private CBool _b;
		private CInt32 _id;

		[Ordinal(0)] 
		[RED("i")] 
		public CInt32 I
		{
			get
			{
				if (_i == null)
				{
					_i = (CInt32) CR2WTypeManager.Create("Int32", "i", cr2w, this);
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
		[RED("f")] 
		public CFloat F
		{
			get
			{
				if (_f == null)
				{
					_f = (CFloat) CR2WTypeManager.Create("Float", "f", cr2w, this);
				}
				return _f;
			}
			set
			{
				if (_f == value)
				{
					return;
				}
				_f = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("b")] 
		public CBool B
		{
			get
			{
				if (_b == null)
				{
					_b = (CBool) CR2WTypeManager.Create("Bool", "b", cr2w, this);
				}
				return _b;
			}
			set
			{
				if (_b == value)
				{
					return;
				}
				_b = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("id")] 
		public CInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CInt32) CR2WTypeManager.Create("Int32", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		public Ref_4_5_Attributes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
