using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Class_2_7 : CVariable
	{
		private CInt32 _var0;

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

		public Sample_Class_2_7(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
