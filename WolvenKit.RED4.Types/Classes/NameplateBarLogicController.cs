using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NameplateBarLogicController : ProgressBarSimpleWidgetLogicController
	{
		[Ordinal(24)] 
		[RED("damagePreview")] 
		public CWeakHandle<DamagePreviewController> DamagePreview
		{
			get => GetPropertyValue<CWeakHandle<DamagePreviewController>>();
			set => SetPropertyValue<CWeakHandle<DamagePreviewController>>(value);
		}
	}
}
