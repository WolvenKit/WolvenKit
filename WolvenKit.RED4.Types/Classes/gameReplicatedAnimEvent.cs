using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameReplicatedAnimEvent : entReplicatedItem
	{
		[Ordinal(2)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
