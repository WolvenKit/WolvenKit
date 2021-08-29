using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StealthMappinGameController : gameuiWidgetGameController
	{
		private CWeakHandle<gameuiStealthMappinController> _controller;
		private CWeakHandle<NPCPuppet> _ownerNPC;

		[Ordinal(2)] 
		[RED("controller")] 
		public CWeakHandle<gameuiStealthMappinController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(3)] 
		[RED("ownerNPC")] 
		public CWeakHandle<NPCPuppet> OwnerNPC
		{
			get => GetProperty(ref _ownerNPC);
			set => SetProperty(ref _ownerNPC, value);
		}
	}
}
