using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TargetKilledHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("lastTarget")] 
		public CWeakHandle<gameObject> LastTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}
	}
}
