using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BraindanceBlackboardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _activeBraindanceVisionMode;
		private gamebbScriptID_Int32 _lastBraindanceVisionMode;
		private gamebbScriptID_Float _progress;
		private gamebbScriptID_Float _sectionTime;
		private gamebbScriptID_Variant _clue;
		private gamebbScriptID_Bool _isActive;
		private gamebbScriptID_Bool _enableExit;
		private gamebbScriptID_Bool _isFPP;
		private gamebbScriptID_Variant _playbackSpeed;
		private gamebbScriptID_Variant _playbackDirection;

		[Ordinal(0)] 
		[RED("activeBraindanceVisionMode")] 
		public gamebbScriptID_Int32 ActiveBraindanceVisionMode
		{
			get => GetProperty(ref _activeBraindanceVisionMode);
			set => SetProperty(ref _activeBraindanceVisionMode, value);
		}

		[Ordinal(1)] 
		[RED("lastBraindanceVisionMode")] 
		public gamebbScriptID_Int32 LastBraindanceVisionMode
		{
			get => GetProperty(ref _lastBraindanceVisionMode);
			set => SetProperty(ref _lastBraindanceVisionMode, value);
		}

		[Ordinal(2)] 
		[RED("Progress")] 
		public gamebbScriptID_Float Progress
		{
			get => GetProperty(ref _progress);
			set => SetProperty(ref _progress, value);
		}

		[Ordinal(3)] 
		[RED("SectionTime")] 
		public gamebbScriptID_Float SectionTime
		{
			get => GetProperty(ref _sectionTime);
			set => SetProperty(ref _sectionTime, value);
		}

		[Ordinal(4)] 
		[RED("Clue")] 
		public gamebbScriptID_Variant Clue
		{
			get => GetProperty(ref _clue);
			set => SetProperty(ref _clue, value);
		}

		[Ordinal(5)] 
		[RED("IsActive")] 
		public gamebbScriptID_Bool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(6)] 
		[RED("EnableExit")] 
		public gamebbScriptID_Bool EnableExit
		{
			get => GetProperty(ref _enableExit);
			set => SetProperty(ref _enableExit, value);
		}

		[Ordinal(7)] 
		[RED("IsFPP")] 
		public gamebbScriptID_Bool IsFPP
		{
			get => GetProperty(ref _isFPP);
			set => SetProperty(ref _isFPP, value);
		}

		[Ordinal(8)] 
		[RED("PlaybackSpeed")] 
		public gamebbScriptID_Variant PlaybackSpeed
		{
			get => GetProperty(ref _playbackSpeed);
			set => SetProperty(ref _playbackSpeed, value);
		}

		[Ordinal(9)] 
		[RED("PlaybackDirection")] 
		public gamebbScriptID_Variant PlaybackDirection
		{
			get => GetProperty(ref _playbackDirection);
			set => SetProperty(ref _playbackDirection, value);
		}

		public BraindanceBlackboardDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
