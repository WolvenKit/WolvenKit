using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NameplateBarLogicController : ProgressBarSimpleWidgetLogicController
	{
		private CWeakHandle<DamagePreviewController> _damagePreview;

		[Ordinal(24)] 
		[RED("damagePreview")] 
		public CWeakHandle<DamagePreviewController> DamagePreview
		{
			get => GetProperty(ref _damagePreview);
			set => SetProperty(ref _damagePreview, value);
		}
	}
}
