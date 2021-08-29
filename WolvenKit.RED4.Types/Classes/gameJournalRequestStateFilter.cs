using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalRequestStateFilter : RedBaseClass
	{
		private CBool _inactive;
		private CBool _active;
		private CBool _succeeded;
		private CBool _failed;

		[Ordinal(0)] 
		[RED("inactive")] 
		public CBool Inactive
		{
			get => GetProperty(ref _inactive);
			set => SetProperty(ref _inactive, value);
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(2)] 
		[RED("succeeded")] 
		public CBool Succeeded
		{
			get => GetProperty(ref _succeeded);
			set => SetProperty(ref _succeeded, value);
		}

		[Ordinal(3)] 
		[RED("failed")] 
		public CBool Failed
		{
			get => GetProperty(ref _failed);
			set => SetProperty(ref _failed, value);
		}
	}
}
