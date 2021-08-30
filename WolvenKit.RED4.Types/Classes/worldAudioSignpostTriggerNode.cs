using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAudioSignpostTriggerNode : worldTriggerAreaNode
	{
		private CName _enterSignpost;
		private CName _exitSignpost;
		private CFloat _exitCooldown;

		[Ordinal(7)] 
		[RED("enterSignpost")] 
		public CName EnterSignpost
		{
			get => GetProperty(ref _enterSignpost);
			set => SetProperty(ref _enterSignpost, value);
		}

		[Ordinal(8)] 
		[RED("exitSignpost")] 
		public CName ExitSignpost
		{
			get => GetProperty(ref _exitSignpost);
			set => SetProperty(ref _exitSignpost, value);
		}

		[Ordinal(9)] 
		[RED("exitCooldown")] 
		public CFloat ExitCooldown
		{
			get => GetProperty(ref _exitCooldown);
			set => SetProperty(ref _exitCooldown, value);
		}

		public worldAudioSignpostTriggerNode()
		{
			_exitCooldown = 5.000000F;
		}
	}
}
