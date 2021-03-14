using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiEntityPreviewGameController : gameuiMenuGameController
	{
		private raRef<entEntityTemplate> _entityToPreview;

		[Ordinal(3)] 
		[RED("entityToPreview")] 
		public raRef<entEntityTemplate> EntityToPreview
		{
			get
			{
				if (_entityToPreview == null)
				{
					_entityToPreview = (raRef<entEntityTemplate>) CR2WTypeManager.Create("raRef:entEntityTemplate", "entityToPreview", cr2w, this);
				}
				return _entityToPreview;
			}
			set
			{
				if (_entityToPreview == value)
				{
					return;
				}
				_entityToPreview = value;
				PropertySet(this);
			}
		}

		public gameuiEntityPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
