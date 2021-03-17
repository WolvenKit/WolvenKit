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
			get => GetProperty(ref _entityToPreview);
			set => SetProperty(ref _entityToPreview, value);
		}

		public gameuiEntityPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
