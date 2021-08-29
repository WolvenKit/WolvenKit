using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnInterruptAvailability_Operation : scnIInterruptManager_Operation
	{
		private CBool _available;

		[Ordinal(0)] 
		[RED("available")] 
		public CBool Available
		{
			get => GetProperty(ref _available);
			set => SetProperty(ref _available, value);
		}
	}
}
