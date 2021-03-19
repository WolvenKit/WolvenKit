using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationNavigationBtn : inkButtonController
	{
		private inkWidgetReference _icon1;
		private CBool _shouldPlaySoundOnHover;
		private CHandle<inkWidget> _root;

		[Ordinal(10)] 
		[RED("icon1")] 
		public inkWidgetReference Icon1
		{
			get => GetProperty(ref _icon1);
			set => SetProperty(ref _icon1, value);
		}

		[Ordinal(11)] 
		[RED("shouldPlaySoundOnHover")] 
		public CBool ShouldPlaySoundOnHover
		{
			get => GetProperty(ref _shouldPlaySoundOnHover);
			set => SetProperty(ref _shouldPlaySoundOnHover, value);
		}

		[Ordinal(12)] 
		[RED("root")] 
		public CHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		public characterCreationNavigationBtn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
