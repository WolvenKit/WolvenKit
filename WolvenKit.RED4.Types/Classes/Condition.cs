using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Condition : RedBaseClass
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
	}
}
