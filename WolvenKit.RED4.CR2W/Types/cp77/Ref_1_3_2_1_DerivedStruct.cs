using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_1_3_2_1_DerivedStruct : Ref_1_3_2_1_BaseStruct
	{
		private CFloat _derivedProp;

		[Ordinal(1)] 
		[RED("derivedProp")] 
		public CFloat DerivedProp
		{
			get => GetProperty(ref _derivedProp);
			set => SetProperty(ref _derivedProp, value);
		}

		public Ref_1_3_2_1_DerivedStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
