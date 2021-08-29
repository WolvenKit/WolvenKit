using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSaveLock : RedBaseClass
	{
		private CEnum<gameSaveLockReason> _reason;

		[Ordinal(0)] 
		[RED("reason")] 
		public CEnum<gameSaveLockReason> Reason
		{
			get => GetProperty(ref _reason);
			set => SetProperty(ref _reason, value);
		}
	}
}
