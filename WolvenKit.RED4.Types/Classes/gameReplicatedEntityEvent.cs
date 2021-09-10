using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameReplicatedEntityEvent : entReplicatedItem
	{
		[Ordinal(2)] 
		[RED("value")] 
		public CHandle<redEvent> Value
		{
			get => GetPropertyValue<CHandle<redEvent>>();
			set => SetPropertyValue<CHandle<redEvent>>(value);
		}
	}
}
