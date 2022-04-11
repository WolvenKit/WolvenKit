using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ClueLockNotification : HUDManagerRequest
	{
		[Ordinal(1)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
