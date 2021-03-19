using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StealthMappinGameController : gameuiWidgetGameController
	{
		private wCHandle<gameuiStealthMappinController> _controller;
		private wCHandle<NPCPuppet> _ownerNPC;

		[Ordinal(2)] 
		[RED("controller")] 
		public wCHandle<gameuiStealthMappinController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(3)] 
		[RED("ownerNPC")] 
		public wCHandle<NPCPuppet> OwnerNPC
		{
			get => GetProperty(ref _ownerNPC);
			set => SetProperty(ref _ownerNPC, value);
		}

		public StealthMappinGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
