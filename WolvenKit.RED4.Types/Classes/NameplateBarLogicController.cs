using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NameplateBarLogicController : ProgressBarSimpleWidgetLogicController
	{
		[Ordinal(24)] 
		[RED("damagePreview")] 
		public CWeakHandle<DamagePreviewController> DamagePreview
		{
			get => GetPropertyValue<CWeakHandle<DamagePreviewController>>();
			set => SetPropertyValue<CWeakHandle<DamagePreviewController>>(value);
		}

		public NameplateBarLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
