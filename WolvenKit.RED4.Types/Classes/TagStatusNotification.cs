using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TagStatusNotification : HUDManagerRequest
	{
		[Ordinal(1)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
