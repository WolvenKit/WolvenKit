using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetQuickHackEvent : redEvent
	{
		private CBool _wasQuickHacked;
		private CName _quickHackName;

		[Ordinal(0)] 
		[RED("wasQuickHacked")] 
		public CBool WasQuickHacked
		{
			get => GetProperty(ref _wasQuickHacked);
			set => SetProperty(ref _wasQuickHacked, value);
		}

		[Ordinal(1)] 
		[RED("quickHackName")] 
		public CName QuickHackName
		{
			get => GetProperty(ref _quickHackName);
			set => SetProperty(ref _quickHackName, value);
		}
	}
}
