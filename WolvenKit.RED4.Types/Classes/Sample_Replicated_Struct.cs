using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Sample_Replicated_Struct : RedBaseClass
	{
		private CBool _a;
		private CBool _b;
		private CBool _c;
		private CBool _d_not_replicated_still_OK;

		[Ordinal(0)] 
		[RED("a")] 
		public CBool A
		{
			get => GetProperty(ref _a);
			set => SetProperty(ref _a, value);
		}

		[Ordinal(1)] 
		[RED("b")] 
		public CBool B
		{
			get => GetProperty(ref _b);
			set => SetProperty(ref _b, value);
		}

		[Ordinal(2)] 
		[RED("c")] 
		public CBool C
		{
			get => GetProperty(ref _c);
			set => SetProperty(ref _c, value);
		}

		[Ordinal(3)] 
		[RED("d_not_replicated_still_OK")] 
		public CBool D_not_replicated_still_OK
		{
			get => GetProperty(ref _d_not_replicated_still_OK);
			set => SetProperty(ref _d_not_replicated_still_OK, value);
		}
	}
}
