using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ManagePersonalLinkChangeEvent : redEvent
	{
		private CBool _shouldEquip;

		[Ordinal(0)] 
		[RED("shouldEquip")] 
		public CBool ShouldEquip
		{
			get => GetProperty(ref _shouldEquip);
			set => SetProperty(ref _shouldEquip, value);
		}
	}
}
