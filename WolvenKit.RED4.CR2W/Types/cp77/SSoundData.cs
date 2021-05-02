using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SSoundData : CVariable
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

		public SSoundData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
