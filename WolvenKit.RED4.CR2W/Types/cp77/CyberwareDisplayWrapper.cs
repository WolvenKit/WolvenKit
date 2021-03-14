using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareDisplayWrapper : IScriptable
	{
		private CHandle<InventoryItemDisplayController> _controller;

		[Ordinal(0)] 
		[RED("controller")] 
		public CHandle<InventoryItemDisplayController> Controller
		{
			get
			{
				if (_controller == null)
				{
					_controller = (CHandle<InventoryItemDisplayController>) CR2WTypeManager.Create("handle:InventoryItemDisplayController", "controller", cr2w, this);
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

		public CyberwareDisplayWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
