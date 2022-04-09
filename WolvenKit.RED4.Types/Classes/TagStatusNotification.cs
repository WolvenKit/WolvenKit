using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TagStatusNotification : HUDManagerRequest
	{
		[Ordinal(1)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TagStatusNotification()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
