using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCallbackData : IScriptable
	{
		private CEnum<inkIconResult> _loadResult;
		private wCHandle<inkImageWidget> _targetWidget;
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
		public wCHandle<inkImageWidget> TargetWidget
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

		public inkCallbackData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
