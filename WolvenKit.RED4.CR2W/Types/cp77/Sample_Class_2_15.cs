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
			get => GetProperty(ref _var0);
			set => SetProperty(ref _var0, value);
		}

		[Ordinal(1)] 
		[RED("var1")] 
		public CFloat Var1
		{
			get => GetProperty(ref _var1);
			set => SetProperty(ref _var1, value);
		}

		[Ordinal(2)] 
		[RED("var2")] 
		public CInt32 Var2
		{
			get => GetProperty(ref _var2);
			set => SetProperty(ref _var2, value);
		}

		[Ordinal(3)] 
		[RED("var3")] 
		public CInt32 Var3
		{
			get => GetProperty(ref _var3);
			set => SetProperty(ref _var3, value);
		}

		public Sample_Class_2_15(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
