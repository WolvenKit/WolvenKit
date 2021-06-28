using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_1_3_2_DerivedStruct : Ref_1_3_2_NonTrivialStruct
	{
		private CBool _prop3;

		[Ordinal(2)] 
		[RED("prop3")] 
		public CBool Prop3
		{
			get => GetProperty(ref _prop3);
			set => SetProperty(ref _prop3, value);
		}

		public Ref_1_3_2_DerivedStruct(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
