using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_1_3_2_NonTrivialStruct : CVariable
	{
		private CFloat _prop1;
		private Ref_1_3_2_TrivialStruct _prop2;

		[Ordinal(0)] 
		[RED("prop1")] 
		public CFloat Prop1
		{
			get => GetProperty(ref _prop1);
			set => SetProperty(ref _prop1, value);
		}

		[Ordinal(1)] 
		[RED("prop2")] 
		public Ref_1_3_2_TrivialStruct Prop2
		{
			get => GetProperty(ref _prop2);
			set => SetProperty(ref _prop2, value);
		}

		public Ref_1_3_2_NonTrivialStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
