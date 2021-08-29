using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TargetKilledHitPrereqCondition : BaseHitPrereqCondition
	{
		private CWeakHandle<gameObject> _lastTarget;

		[Ordinal(1)] 
		[RED("lastTarget")] 
		public CWeakHandle<gameObject> LastTarget
		{
			get => GetProperty(ref _lastTarget);
			set => SetProperty(ref _lastTarget, value);
		}
	}
}
