using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleQuestWindowDestructionEvent : redEvent
	{
		private CName _windowName;
		private CEnum<vehicleQuestWindowDestruction> _window;

		[Ordinal(0)] 
		[RED("windowName")] 
		public CName WindowName
		{
			get => GetProperty(ref _windowName);
			set => SetProperty(ref _windowName, value);
		}

		[Ordinal(1)] 
		[RED("window")] 
		public CEnum<vehicleQuestWindowDestruction> Window
		{
			get => GetProperty(ref _window);
			set => SetProperty(ref _window, value);
		}
	}
}
