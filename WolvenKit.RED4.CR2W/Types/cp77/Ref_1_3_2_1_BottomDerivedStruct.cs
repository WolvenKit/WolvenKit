using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_1_3_2_1_BottomDerivedStruct : Ref_1_3_2_1_DerivedStruct
	{
		private CBool _bottomDerivedProp;

		[Ordinal(2)] 
		[RED("bottomDerivedProp")] 
		public CBool BottomDerivedProp
		{
			get => GetProperty(ref _bottomDerivedProp);
			set => SetProperty(ref _bottomDerivedProp, value);
		}

		public Ref_1_3_2_1_BottomDerivedStruct(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
