using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RefreshSlavesEvent : ProcessDevicesEvent
	{
		private CBool _onInitialize;
		private CBool _force;

		[Ordinal(1)] 
		[RED("onInitialize")] 
		public CBool OnInitialize
		{
			get => GetProperty(ref _onInitialize);
			set => SetProperty(ref _onInitialize, value);
		}

		[Ordinal(2)] 
		[RED("force")] 
		public CBool Force
		{
			get => GetProperty(ref _force);
			set => SetProperty(ref _force, value);
		}
	}
}
