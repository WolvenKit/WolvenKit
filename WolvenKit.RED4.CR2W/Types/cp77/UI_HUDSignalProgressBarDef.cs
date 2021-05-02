using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_HUDSignalProgressBarDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _timerID;
		private gamebbScriptID_Uint32 _state;
		private gamebbScriptID_Float _progress;
		private gamebbScriptID_Float _signalStrength;
		private gamebbScriptID_Bool _isInRange;

		[Ordinal(0)] 
		[RED("TimerID")] 
		public gamebbScriptID_Variant TimerID
		{
			get => GetProperty(ref _timerID);
			set => SetProperty(ref _timerID, value);
		}

		[Ordinal(1)] 
		[RED("State")] 
		public gamebbScriptID_Uint32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(2)] 
		[RED("Progress")] 
		public gamebbScriptID_Float Progress
		{
			get => GetProperty(ref _progress);
			set => SetProperty(ref _progress, value);
		}

		[Ordinal(3)] 
		[RED("SignalStrength")] 
		public gamebbScriptID_Float SignalStrength
		{
			get => GetProperty(ref _signalStrength);
			set => SetProperty(ref _signalStrength, value);
		}

		[Ordinal(4)] 
		[RED("IsInRange")] 
		public gamebbScriptID_Bool IsInRange
		{
			get => GetProperty(ref _isInRange);
			set => SetProperty(ref _isInRange, value);
		}

		public UI_HUDSignalProgressBarDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
