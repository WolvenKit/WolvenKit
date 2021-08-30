using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AccessPoint : InteractiveMasterDevice
	{
		private CString _networkName;
		private CBool _isPlayerInBreachView;
		private CBool _isRevealed;
		private CHandle<BreachViewTimeListener> _breachViewTimeListener;
		private CUInt32 _upload_program_listener_id;

		[Ordinal(97)] 
		[RED("networkName")] 
		public CString NetworkName
		{
			get => GetProperty(ref _networkName);
			set => SetProperty(ref _networkName, value);
		}

		[Ordinal(98)] 
		[RED("isPlayerInBreachView")] 
		public CBool IsPlayerInBreachView
		{
			get => GetProperty(ref _isPlayerInBreachView);
			set => SetProperty(ref _isPlayerInBreachView, value);
		}

		[Ordinal(99)] 
		[RED("isRevealed")] 
		public CBool IsRevealed
		{
			get => GetProperty(ref _isRevealed);
			set => SetProperty(ref _isRevealed, value);
		}

		[Ordinal(100)] 
		[RED("breachViewTimeListener")] 
		public CHandle<BreachViewTimeListener> BreachViewTimeListener
		{
			get => GetProperty(ref _breachViewTimeListener);
			set => SetProperty(ref _breachViewTimeListener, value);
		}

		[Ordinal(101)] 
		[RED("upload_program_listener_id")] 
		public CUInt32 Upload_program_listener_id
		{
			get => GetProperty(ref _upload_program_listener_id);
			set => SetProperty(ref _upload_program_listener_id, value);
		}

		public AccessPoint()
		{
			_networkName = new() { Text = "Local Network 1" };
		}
	}
}
