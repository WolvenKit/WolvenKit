using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ManagePersonalLinkChangeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("shouldEquip")] 
		public CBool ShouldEquip
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
