using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSaveLock : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("reason")] 
		public CEnum<gameSaveLockReason> Reason
		{
			get => GetPropertyValue<CEnum<gameSaveLockReason>>();
			set => SetPropertyValue<CEnum<gameSaveLockReason>>(value);
		}
	}
}
