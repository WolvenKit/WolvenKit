using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MissingWorkspotComponentFailsafeEvent : redEvent
	{
		private entEntityID _playerEntityID;

		[Ordinal(0)] 
		[RED("playerEntityID")] 
		public entEntityID PlayerEntityID
		{
			get => GetProperty(ref _playerEntityID);
			set => SetProperty(ref _playerEntityID, value);
		}
	}
}
