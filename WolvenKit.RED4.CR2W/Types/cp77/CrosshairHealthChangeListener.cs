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
			get => GetProperty(ref _parentCrosshair);
			set => SetProperty(ref _parentCrosshair, value);
		}

		public CrosshairHealthChangeListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
