using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickhackInstance : ModuleInstance
	{
		private CBool _open;
		private CBool _process;

		[Ordinal(6)] 
		[RED("open")] 
		public CBool Open
		{
			get => GetProperty(ref _open);
			set => SetProperty(ref _open, value);
		}

		[Ordinal(7)] 
		[RED("process")] 
		public CBool Process
		{
			get => GetProperty(ref _process);
			set => SetProperty(ref _process, value);
		}
	}
}
