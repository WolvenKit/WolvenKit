using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionCooldownEvent : redEvent
	{
		private CooldownStorageID _storageID;

		[Ordinal(0)] 
		[RED("storageID")] 
		public CooldownStorageID StorageID
		{
			get => GetProperty(ref _storageID);
			set => SetProperty(ref _storageID, value);
		}
	}
}
