using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetControllersSnapshot : CVariable
	{
		private CArray<gameMuppetControllerSnapshot> _controllers;

		[Ordinal(0)] 
		[RED("controllers")] 
		public CArray<gameMuppetControllerSnapshot> Controllers
		{
			get
			{
				if (_controllers == null)
				{
					_controllers = (CArray<gameMuppetControllerSnapshot>) CR2WTypeManager.Create("array:gameMuppetControllerSnapshot", "controllers", cr2w, this);
				}
				return _controllers;
			}
			set
			{
				if (_controllers == value)
				{
					return;
				}
				_controllers = value;
				PropertySet(this);
			}
		}

		public gameMuppetControllersSnapshot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
