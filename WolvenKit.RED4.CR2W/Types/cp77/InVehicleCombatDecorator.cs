using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InVehicleCombatDecorator : AIVehicleTaskAbstract
	{
		private wCHandle<gameObject> _targetToChase;

		[Ordinal(0)] 
		[RED("targetToChase")] 
		public wCHandle<gameObject> TargetToChase
		{
			get => GetProperty(ref _targetToChase);
			set => SetProperty(ref _targetToChase, value);
		}

		public InVehicleCombatDecorator(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
