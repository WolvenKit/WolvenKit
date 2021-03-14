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
			get
			{
				if (_controller == null)
				{
					_controller = (wCHandle<gameuiStealthMappinController>) CR2WTypeManager.Create("whandle:gameuiStealthMappinController", "controller", cr2w, this);
				}
				return _controller;
			}
			set
			{
				if (_controller == value)
				{
					return;
				}
				_controller = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ownerNPC")] 
		public wCHandle<NPCPuppet> OwnerNPC
		{
			get
			{
				if (_ownerNPC == null)
				{
					_ownerNPC = (wCHandle<NPCPuppet>) CR2WTypeManager.Create("whandle:NPCPuppet", "ownerNPC", cr2w, this);
				}
				return _ownerNPC;
			}
			set
			{
				if (_ownerNPC == value)
				{
					return;
				}
				_ownerNPC = value;
				PropertySet(this);
			}
		}

		public StealthMappinGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
