using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairHealthChangeListener : gameCustomValueStatPoolsListener
	{
		private CHandle<gameuiCrosshairBaseGameController> _parentCrosshair;

		[Ordinal(0)] 
		[RED("parentCrosshair")] 
		public CHandle<gameuiCrosshairBaseGameController> ParentCrosshair
		{
			get
			{
				if (_parentCrosshair == null)
				{
					_parentCrosshair = (CHandle<gameuiCrosshairBaseGameController>) CR2WTypeManager.Create("handle:gameuiCrosshairBaseGameController", "parentCrosshair", cr2w, this);
				}
				return _parentCrosshair;
			}
			set
			{
				if (_parentCrosshair == value)
				{
					return;
				}
				_parentCrosshair = value;
				PropertySet(this);
			}
		}

		public CrosshairHealthChangeListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
