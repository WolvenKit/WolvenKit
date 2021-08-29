using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questInspectListenerEvent : redEvent
	{
		private CHandle<questObjectInspectListener> _listener;
		private CBool _register;

		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<questObjectInspectListener> Listener
		{
			get => GetProperty(ref _listener);
			set => SetProperty(ref _listener, value);
		}

		[Ordinal(1)] 
		[RED("register")] 
		public CBool Register
		{
			get => GetProperty(ref _register);
			set => SetProperty(ref _register, value);
		}
	}
}
