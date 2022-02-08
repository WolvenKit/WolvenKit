using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemIdWrapper : IScriptable
	{
		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public ItemIdWrapper()
		{
			ItemID = new();
		}
	}
}
