using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractiveAd : InteractiveDevice
	{
		private CHandle<gameStaticTriggerAreaComponent> _triggerComponent;
		private CHandle<gameStaticTriggerAreaComponent> _triggerExitComponent;
		private CHandle<WorldWidgetComponent> _aduiComponent;
		private CBool _showAd;
		private CBool _showVendor;

		[Ordinal(96)] 
		[RED("triggerComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerComponent
		{
			get => GetProperty(ref _triggerComponent);
			set => SetProperty(ref _triggerComponent, value);
		}

		[Ordinal(97)] 
		[RED("triggerExitComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerExitComponent
		{
			get => GetProperty(ref _triggerExitComponent);
			set => SetProperty(ref _triggerExitComponent, value);
		}

		[Ordinal(98)] 
		[RED("aduiComponent")] 
		public CHandle<WorldWidgetComponent> AduiComponent
		{
			get => GetProperty(ref _aduiComponent);
			set => SetProperty(ref _aduiComponent, value);
		}

		[Ordinal(99)] 
		[RED("showAd")] 
		public CBool ShowAd
		{
			get => GetProperty(ref _showAd);
			set => SetProperty(ref _showAd, value);
		}

		[Ordinal(100)] 
		[RED("showVendor")] 
		public CBool ShowVendor
		{
			get => GetProperty(ref _showVendor);
			set => SetProperty(ref _showVendor, value);
		}

		public InteractiveAd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
