using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudButtonReminderGameController : gameuiHUDGameController
	{
		private inkCompoundWidgetReference _button1;
		private inkCompoundWidgetReference _button2;
		private inkCompoundWidgetReference _button3;
		private CHandle<gameIBlackboard> _uiHudButtonHelpBB;
		private CUInt32 _interactingWithDeviceBBID;

		[Ordinal(9)] 
		[RED("Button1")] 
		public inkCompoundWidgetReference Button1
		{
			get => GetProperty(ref _button1);
			set => SetProperty(ref _button1, value);
		}

		[Ordinal(10)] 
		[RED("Button2")] 
		public inkCompoundWidgetReference Button2
		{
			get => GetProperty(ref _button2);
			set => SetProperty(ref _button2, value);
		}

		[Ordinal(11)] 
		[RED("Button3")] 
		public inkCompoundWidgetReference Button3
		{
			get => GetProperty(ref _button3);
			set => SetProperty(ref _button3, value);
		}

		[Ordinal(12)] 
		[RED("uiHudButtonHelpBB")] 
		public CHandle<gameIBlackboard> UiHudButtonHelpBB
		{
			get => GetProperty(ref _uiHudButtonHelpBB);
			set => SetProperty(ref _uiHudButtonHelpBB, value);
		}

		[Ordinal(13)] 
		[RED("interactingWithDeviceBBID")] 
		public CUInt32 InteractingWithDeviceBBID
		{
			get => GetProperty(ref _interactingWithDeviceBBID);
			set => SetProperty(ref _interactingWithDeviceBBID, value);
		}

		public hudButtonReminderGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
