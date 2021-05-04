using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PanzerSmartWeaponTargetController : inkWidgetLogicController
	{
		private inkTextWidgetReference _distanceText;
		private CHandle<inkanimProxy> _lockingAnimationProxy;

		[Ordinal(1)] 
		[RED("distanceText")] 
		public inkTextWidgetReference DistanceText
		{
			get => GetProperty(ref _distanceText);
			set => SetProperty(ref _distanceText, value);
		}

		[Ordinal(2)] 
		[RED("lockingAnimationProxy")] 
		public CHandle<inkanimProxy> LockingAnimationProxy
		{
			get => GetProperty(ref _lockingAnimationProxy);
			set => SetProperty(ref _lockingAnimationProxy, value);
		}

		public PanzerSmartWeaponTargetController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
