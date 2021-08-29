using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questContentLock_ConditionType : questIContentConditionType
	{
		private CBool _isContentBlocked;

		[Ordinal(0)] 
		[RED("isContentBlocked")] 
		public CBool IsContentBlocked
		{
			get => GetProperty(ref _isContentBlocked);
			set => SetProperty(ref _isContentBlocked, value);
		}
	}
}
