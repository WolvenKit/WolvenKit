using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkCallbackData : IScriptable
	{
		private CEnum<inkIconResult> _loadResult;
		private CWeakHandle<inkImageWidget> _targetWidget;
		private CString _errorMsg;
		private TweakDBID _iconSrc;

		[Ordinal(0)] 
		[RED("loadResult")] 
		public CEnum<inkIconResult> LoadResult
		{
			get => GetProperty(ref _loadResult);
			set => SetProperty(ref _loadResult, value);
		}

		[Ordinal(1)] 
		[RED("targetWidget")] 
		public CWeakHandle<inkImageWidget> TargetWidget
		{
			get => GetProperty(ref _targetWidget);
			set => SetProperty(ref _targetWidget, value);
		}

		[Ordinal(2)] 
		[RED("errorMsg")] 
		public CString ErrorMsg
		{
			get => GetProperty(ref _errorMsg);
			set => SetProperty(ref _errorMsg, value);
		}

		[Ordinal(3)] 
		[RED("iconSrc")] 
		public TweakDBID IconSrc
		{
			get => GetProperty(ref _iconSrc);
			set => SetProperty(ref _iconSrc, value);
		}
	}
}
