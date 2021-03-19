using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldMapTooltipBaseController : inkWidgetLogicController
	{
		private inkWidgetReference _root;
		private CHandle<inkanimProxy> _showHideAnim;
		private CBool _visible;
		private CBool _active;

		[Ordinal(1)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(2)] 
		[RED("showHideAnim")] 
		public CHandle<inkanimProxy> ShowHideAnim
		{
			get => GetProperty(ref _showHideAnim);
			set => SetProperty(ref _showHideAnim, value);
		}

		[Ordinal(3)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetProperty(ref _visible);
			set => SetProperty(ref _visible, value);
		}

		[Ordinal(4)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		public WorldMapTooltipBaseController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
