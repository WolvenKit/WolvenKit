using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Melee_Misc : gameuiCrosshairBaseGameController
	{
		private inkWidgetReference _targetColorChange;

		[Ordinal(18)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get
			{
				if (_targetColorChange == null)
				{
					_targetColorChange = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "targetColorChange", cr2w, this);
				}
				return _targetColorChange;
			}
			set
			{
				if (_targetColorChange == value)
				{
					return;
				}
				_targetColorChange = value;
				PropertySet(this);
			}
		}

		public Crosshair_Melee_Misc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
