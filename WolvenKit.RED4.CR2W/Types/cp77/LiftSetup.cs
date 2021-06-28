using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LiftSetup : CVariable
	{
		private CInt32 _startingFloorTerminal;
		private CFloat _liftSpeed;
		private CFloat _liftStartingDelay;
		private CFloat _liftTravelTimeOverride;
		private CBool _isLiftTravelTimeOverride;
		private CFloat _emptyLiftSpeedMultiplier;
		private CInt32 _radioStationNumer;
		private CName _speakerDestroyedQuestFact;
		private CName _speakerDestroyedVFX;
		private CString _authorizationTextOverride;

		[Ordinal(0)] 
		[RED("startingFloorTerminal")] 
		public CInt32 StartingFloorTerminal
		{
			get => GetProperty(ref _startingFloorTerminal);
			set => SetProperty(ref _startingFloorTerminal, value);
		}

		[Ordinal(1)] 
		[RED("liftSpeed")] 
		public CFloat LiftSpeed
		{
			get => GetProperty(ref _liftSpeed);
			set => SetProperty(ref _liftSpeed, value);
		}

		[Ordinal(2)] 
		[RED("liftStartingDelay")] 
		public CFloat LiftStartingDelay
		{
			get => GetProperty(ref _liftStartingDelay);
			set => SetProperty(ref _liftStartingDelay, value);
		}

		[Ordinal(3)] 
		[RED("liftTravelTimeOverride")] 
		public CFloat LiftTravelTimeOverride
		{
			get => GetProperty(ref _liftTravelTimeOverride);
			set => SetProperty(ref _liftTravelTimeOverride, value);
		}

		[Ordinal(4)] 
		[RED("isLiftTravelTimeOverride")] 
		public CBool IsLiftTravelTimeOverride
		{
			get => GetProperty(ref _isLiftTravelTimeOverride);
			set => SetProperty(ref _isLiftTravelTimeOverride, value);
		}

		[Ordinal(5)] 
		[RED("emptyLiftSpeedMultiplier")] 
		public CFloat EmptyLiftSpeedMultiplier
		{
			get => GetProperty(ref _emptyLiftSpeedMultiplier);
			set => SetProperty(ref _emptyLiftSpeedMultiplier, value);
		}

		[Ordinal(6)] 
		[RED("radioStationNumer")] 
		public CInt32 RadioStationNumer
		{
			get => GetProperty(ref _radioStationNumer);
			set => SetProperty(ref _radioStationNumer, value);
		}

		[Ordinal(7)] 
		[RED("speakerDestroyedQuestFact")] 
		public CName SpeakerDestroyedQuestFact
		{
			get => GetProperty(ref _speakerDestroyedQuestFact);
			set => SetProperty(ref _speakerDestroyedQuestFact, value);
		}

		[Ordinal(8)] 
		[RED("speakerDestroyedVFX")] 
		public CName SpeakerDestroyedVFX
		{
			get => GetProperty(ref _speakerDestroyedVFX);
			set => SetProperty(ref _speakerDestroyedVFX, value);
		}

		[Ordinal(9)] 
		[RED("authorizationTextOverride")] 
		public CString AuthorizationTextOverride
		{
			get => GetProperty(ref _authorizationTextOverride);
			set => SetProperty(ref _authorizationTextOverride, value);
		}

		public LiftSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
