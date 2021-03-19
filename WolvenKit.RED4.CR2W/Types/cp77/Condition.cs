using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Condition : CVariable
	{
		private CBool _passed;
		private CString _description;

		[Ordinal(0)] 
		[RED("passed")] 
		public CBool Passed
		{
			get => GetProperty(ref _passed);
			set => SetProperty(ref _passed, value);
		}

		[Ordinal(1)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		public Condition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
