using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SSoundData : RedBaseClass
	{
		private CName _widgetAudioName;
		private CName _onPressKey;
		private CName _onReleaseKey;
		private CName _onHoverOverKey;
		private CName _onHoverOutKey;

		[Ordinal(0)] 
		[RED("widgetAudioName")] 
		public CName WidgetAudioName
		{
			get => GetProperty(ref _widgetAudioName);
			set => SetProperty(ref _widgetAudioName, value);
		}

		[Ordinal(1)] 
		[RED("onPressKey")] 
		public CName OnPressKey
		{
			get => GetProperty(ref _onPressKey);
			set => SetProperty(ref _onPressKey, value);
		}

		[Ordinal(2)] 
		[RED("onReleaseKey")] 
		public CName OnReleaseKey
		{
			get => GetProperty(ref _onReleaseKey);
			set => SetProperty(ref _onReleaseKey, value);
		}

		[Ordinal(3)] 
		[RED("onHoverOverKey")] 
		public CName OnHoverOverKey
		{
			get => GetProperty(ref _onHoverOverKey);
			set => SetProperty(ref _onHoverOverKey, value);
		}

		[Ordinal(4)] 
		[RED("onHoverOutKey")] 
		public CName OnHoverOutKey
		{
			get => GetProperty(ref _onHoverOutKey);
			set => SetProperty(ref _onHoverOutKey, value);
		}

		public SSoundData()
		{
			_widgetAudioName = "Button";
		}
	}
}
