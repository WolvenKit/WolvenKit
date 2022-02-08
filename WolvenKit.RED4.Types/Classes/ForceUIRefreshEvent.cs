using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceUIRefreshEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public ForceUIRefreshEvent()
		{
			OwnerID = new();
		}
	}
}
