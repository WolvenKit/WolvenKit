using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NameplateBarLogicController : ProgressBarSimpleWidgetLogicController
	{
		private wCHandle<DamagePreviewController> _damagePreview;

		[Ordinal(24)] 
		[RED("damagePreview")] 
		public wCHandle<DamagePreviewController> DamagePreview
		{
			get => GetProperty(ref _damagePreview);
			set => SetProperty(ref _damagePreview, value);
		}

		public NameplateBarLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
