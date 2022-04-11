using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionCooldownEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("storageID")] 
		public CooldownStorageID StorageID
		{
			get => GetPropertyValue<CooldownStorageID>();
			set => SetPropertyValue<CooldownStorageID>(value);
		}

		public ActionCooldownEvent()
		{
			StorageID = new();
		}
	}
}
