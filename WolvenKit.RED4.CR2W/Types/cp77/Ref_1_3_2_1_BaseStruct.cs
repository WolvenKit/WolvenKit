using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_1_3_2_1_BaseStruct : CVariable
	{
		private CInt32 _baseProp;

		[Ordinal(0)] 
		[RED("baseProp")] 
		public CInt32 BaseProp
		{
			get => GetProperty(ref _baseProp);
			set => SetProperty(ref _baseProp, value);
		}

		public Ref_1_3_2_1_BaseStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
