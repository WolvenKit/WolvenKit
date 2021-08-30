using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiHUDGameController : gameuiWidgetGameController
	{
		private CHandle<inkanimDefinition> _showAnimDef;
		private CHandle<inkanimDefinition> _hideAnimDef;
		private CName _showAnimationName;
		private CName _hideAnimationName;
		private CBool _moduleShown;
		private CHandle<inkanimProxy> _showAnimProxy;
		private CHandle<inkanimProxy> _hideAnimProxy;

		[Ordinal(2)] 
		[RED("showAnimDef")] 
		public CHandle<inkanimDefinition> ShowAnimDef
		{
			get => GetProperty(ref _showAnimDef);
			set => SetProperty(ref _showAnimDef, value);
		}

		[Ordinal(3)] 
		[RED("hideAnimDef")] 
		public CHandle<inkanimDefinition> HideAnimDef
		{
			get => GetProperty(ref _hideAnimDef);
			set => SetProperty(ref _hideAnimDef, value);
		}

		[Ordinal(4)] 
		[RED("showAnimationName")] 
		public CName ShowAnimationName
		{
			get => GetProperty(ref _showAnimationName);
			set => SetProperty(ref _showAnimationName, value);
		}

		[Ordinal(5)] 
		[RED("hideAnimationName")] 
		public CName HideAnimationName
		{
			get => GetProperty(ref _hideAnimationName);
			set => SetProperty(ref _hideAnimationName, value);
		}

		[Ordinal(6)] 
		[RED("moduleShown")] 
		public CBool ModuleShown
		{
			get => GetProperty(ref _moduleShown);
			set => SetProperty(ref _moduleShown, value);
		}

		[Ordinal(7)] 
		[RED("showAnimProxy")] 
		public CHandle<inkanimProxy> ShowAnimProxy
		{
			get => GetProperty(ref _showAnimProxy);
			set => SetProperty(ref _showAnimProxy, value);
		}

		[Ordinal(8)] 
		[RED("hideAnimProxy")] 
		public CHandle<inkanimProxy> HideAnimProxy
		{
			get => GetProperty(ref _hideAnimProxy);
			set => SetProperty(ref _hideAnimProxy, value);
		}

		public gameuiHUDGameController()
		{
			_showAnimationName = "unfold";
			_hideAnimationName = "fold";
		}
	}
}
