using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class characterCreationNavigationBtn : inkButtonController
	{
		private inkWidgetReference _icon1;
		private CBool _shouldPlaySoundOnHover;
		private CWeakHandle<inkWidget> _root;

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
		public CWeakHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}
	}
}
