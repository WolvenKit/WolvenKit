using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Class_2_15 : CVariable
	{
		private CFloat _var0;
		private CFloat _var1;
		private CInt32 _var2;
		private CInt32 _var3;

		[Ordinal(0)] 
		[RED("var0")] 
		public CFloat Var0
		{
			get
			{
				if (_var0 == null)
				{
					_var0 = (CFloat) CR2WTypeManager.Create("Float", "var0", cr2w, this);
				}
				return _var0;
			}
			set
			{
				if (_var0 == value)
				{
					return;
				}
				_var0 = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("var1")] 
		public CFloat Var1
		{
			get
			{
				if (_var1 == null)
				{
					_var1 = (CFloat) CR2WTypeManager.Create("Float", "var1", cr2w, this);
				}
				return _var1;
			}
			set
			{
				if (_var1 == value)
				{
					return;
				}
				_var1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("var2")] 
		public CInt32 Var2
		{
			get
			{
				if (_var2 == null)
				{
					_var2 = (CInt32) CR2WTypeManager.Create("Int32", "var2", cr2w, this);
				}
				return _var2;
			}
			set
			{
				if (_var2 == value)
				{
					return;
				}
				_var2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("var3")] 
		public CInt32 Var3
		{
			get
			{
				if (_var3 == null)
				{
					_var3 = (CInt32) CR2WTypeManager.Create("Int32", "var3", cr2w, this);
				}
				return _var3;
			}
			set
			{
				if (_var3 == value)
				{
					return;
				}
				_var3 = value;
				PropertySet(this);
			}
		}

		public Sample_Class_2_15(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
