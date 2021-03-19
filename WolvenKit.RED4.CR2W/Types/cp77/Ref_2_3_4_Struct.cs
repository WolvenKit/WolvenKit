using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_2_3_4_Struct : CVariable
	{
		private CInt32 _val;

		[Ordinal(0)] 
		[RED("val")] 
		public CInt32 Val
		{
			get => GetProperty(ref _val);
			set => SetProperty(ref _val, value);
		}

		public Ref_2_3_4_Struct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
