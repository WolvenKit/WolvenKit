using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddOrRemoveListenerForGOEvent : redEvent
	{
		private CHandle<GameObjectListener> _listener;
		private CBool _shouldAdd;

		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<GameObjectListener> Listener
		{
			get => GetProperty(ref _listener);
			set => SetProperty(ref _listener, value);
		}

		[Ordinal(1)] 
		[RED("shouldAdd")] 
		public CBool ShouldAdd
		{
			get => GetProperty(ref _shouldAdd);
			set => SetProperty(ref _shouldAdd, value);
		}
	}
}
