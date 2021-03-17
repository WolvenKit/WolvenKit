using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_1_3_2_2_DerivedStruct : Ref_1_3_2_2_BaseStruct
	{
		private CInt32 _prop2;

		[Ordinal(1)] 
		[RED("prop2")] 
		public CInt32 Prop2
		{
			get => GetProperty(ref _prop2);
			set => SetProperty(ref _prop2, value);
		}

		public Ref_1_3_2_2_DerivedStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
