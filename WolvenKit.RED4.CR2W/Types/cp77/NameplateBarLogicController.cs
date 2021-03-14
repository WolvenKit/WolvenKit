using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NameplateBarLogicController : ProgressBarSimpleWidgetLogicController
	{
		private CHandle<DamagePreviewController> _damagePreview;

		[Ordinal(24)] 
		[RED("damagePreview")] 
		public CHandle<DamagePreviewController> DamagePreview
		{
			get
			{
				if (_damagePreview == null)
				{
					_damagePreview = (CHandle<DamagePreviewController>) CR2WTypeManager.Create("handle:DamagePreviewController", "damagePreview", cr2w, this);
				}
				return _damagePreview;
			}
			set
			{
				if (_damagePreview == value)
				{
					return;
				}
				_damagePreview = value;
				PropertySet(this);
			}
		}

		public NameplateBarLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
