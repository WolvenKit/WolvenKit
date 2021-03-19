using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_1_4_1_Struct : CVariable
	{
		private CInt32 _intProp;

		[Ordinal(0)] 
		[RED("intProp")] 
		public CInt32 IntProp
		{
			get => GetProperty(ref _intProp);
			set => SetProperty(ref _intProp, value);
		}

		public Ref_1_4_1_Struct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
