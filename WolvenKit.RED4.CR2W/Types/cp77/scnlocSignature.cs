using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnlocSignature : CVariable
	{
		private CUInt64 _val;

		[Ordinal(0)] 
		[RED("val")] 
		public CUInt64 Val
		{
			get => GetProperty(ref _val);
			set => SetProperty(ref _val, value);
		}

		public scnlocSignature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
