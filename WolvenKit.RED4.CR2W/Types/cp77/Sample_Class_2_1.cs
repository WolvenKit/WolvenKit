using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Class_2_1 : CVariable
	{
		private CInt32 _var0;
		private CFloat _var1;
		private CString _var2;
		private CName _var3;

		[Ordinal(0)] 
		[RED("var0")] 
		public CInt32 Var0
		{
			get
			{
				if (_var0 == null)
				{
					_var0 = (CInt32) CR2WTypeManager.Create("Int32", "var0", cr2w, this);
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
		public CString Var2
		{
			get
			{
				if (_var2 == null)
				{
					_var2 = (CString) CR2WTypeManager.Create("String", "var2", cr2w, this);
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
		public CName Var3
		{
			get
			{
				if (_var3 == null)
				{
					_var3 = (CName) CR2WTypeManager.Create("CName", "var3", cr2w, this);
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

		public Sample_Class_2_1(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
