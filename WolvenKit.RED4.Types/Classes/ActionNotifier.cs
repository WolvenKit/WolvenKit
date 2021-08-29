using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionNotifier : IScriptable
	{
		private CBool _external;
		private CBool _internal;
		private CBool _failed;

		[Ordinal(0)] 
		[RED("external")] 
		public CBool External
		{
			get => GetProperty(ref _external);
			set => SetProperty(ref _external, value);
		}

		[Ordinal(1)] 
		[RED("internal")] 
		public CBool Internal
		{
			get => GetProperty(ref _internal);
			set => SetProperty(ref _internal, value);
		}

		[Ordinal(2)] 
		[RED("failed")] 
		public CBool Failed
		{
			get => GetProperty(ref _failed);
			set => SetProperty(ref _failed, value);
		}
	}
}
