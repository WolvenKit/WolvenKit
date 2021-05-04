using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AOEAreaSetup : CVariable
	{
		private TweakDBID _areaEffect;
		private TweakDBID _actionName;
		private CBool _blocksVisibility;
		private CBool _isDangerous;
		private CBool _activateOnStartup;
		private CBool _effectsOnlyActiveInArea;
		private CFloat _duration;
		private TweakDBID _actionWidgetRecord;
		private TweakDBID _deviceWidgetRecord;
		private TweakDBID _thumbnailWidgetRecord;

		[Ordinal(0)] 
		[RED("areaEffect")] 
		public TweakDBID AreaEffect
		{
			get => GetProperty(ref _areaEffect);
			set => SetProperty(ref _areaEffect, value);
		}

		[Ordinal(1)] 
		[RED("actionName")] 
		public TweakDBID ActionName
		{
			get => GetProperty(ref _actionName);
			set => SetProperty(ref _actionName, value);
		}

		[Ordinal(2)] 
		[RED("blocksVisibility")] 
		public CBool BlocksVisibility
		{
			get => GetProperty(ref _blocksVisibility);
			set => SetProperty(ref _blocksVisibility, value);
		}

		[Ordinal(3)] 
		[RED("isDangerous")] 
		public CBool IsDangerous
		{
			get => GetProperty(ref _isDangerous);
			set => SetProperty(ref _isDangerous, value);
		}

		[Ordinal(4)] 
		[RED("activateOnStartup")] 
		public CBool ActivateOnStartup
		{
			get => GetProperty(ref _activateOnStartup);
			set => SetProperty(ref _activateOnStartup, value);
		}

		[Ordinal(5)] 
		[RED("effectsOnlyActiveInArea")] 
		public CBool EffectsOnlyActiveInArea
		{
			get => GetProperty(ref _effectsOnlyActiveInArea);
			set => SetProperty(ref _effectsOnlyActiveInArea, value);
		}

		[Ordinal(6)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(7)] 
		[RED("actionWidgetRecord")] 
		public TweakDBID ActionWidgetRecord
		{
			get => GetProperty(ref _actionWidgetRecord);
			set => SetProperty(ref _actionWidgetRecord, value);
		}

		[Ordinal(8)] 
		[RED("deviceWidgetRecord")] 
		public TweakDBID DeviceWidgetRecord
		{
			get => GetProperty(ref _deviceWidgetRecord);
			set => SetProperty(ref _deviceWidgetRecord, value);
		}

		[Ordinal(9)] 
		[RED("thumbnailWidgetRecord")] 
		public TweakDBID ThumbnailWidgetRecord
		{
			get => GetProperty(ref _thumbnailWidgetRecord);
			set => SetProperty(ref _thumbnailWidgetRecord, value);
		}

		public AOEAreaSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
