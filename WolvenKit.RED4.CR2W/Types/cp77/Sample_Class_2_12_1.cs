using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Class_2_12_1 : CVariable
	{
		private Sample_Class_2_12_0 _var0;

		[Ordinal(0)] 
		[RED("var0")] 
		public Sample_Class_2_12_0 Var0
		{
			get => GetProperty(ref _var0);
			set => SetProperty(ref _var0, value);
		}

		public Sample_Class_2_12_1(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
