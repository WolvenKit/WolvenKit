using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDroneMetadata : audioCustomEmitterMetadata
	{
		private CName _boneName;
		private CName _engineStart;
		private CName _engineStop;
		private CName _combatEnter;
		private CName _combatExit;
		private CName _targetLost;
		private CName _idle;
		private CName _initialReaction;
		private CName _investigationIgnore;
		private CName _noClearShot;
		private CName _targetComplies;
		private CName _lookForIntruder;
		private CName _droneDestroyed;
		private CName _droneDefeated;
		private CName _commandHolsterWeapon;
		private CName _commandLeaveArea;
		private CName _finalWarning;
		private CFloat _playDistance;
		private CArray<CName> _decorators;

		[Ordinal(1)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get => GetProperty(ref _boneName);
			set => SetProperty(ref _boneName, value);
		}

		[Ordinal(2)] 
		[RED("engineStart")] 
		public CName EngineStart
		{
			get => GetProperty(ref _engineStart);
			set => SetProperty(ref _engineStart, value);
		}

		[Ordinal(3)] 
		[RED("engineStop")] 
		public CName EngineStop
		{
			get => GetProperty(ref _engineStop);
			set => SetProperty(ref _engineStop, value);
		}

		[Ordinal(4)] 
		[RED("combatEnter")] 
		public CName CombatEnter
		{
			get => GetProperty(ref _combatEnter);
			set => SetProperty(ref _combatEnter, value);
		}

		[Ordinal(5)] 
		[RED("combatExit")] 
		public CName CombatExit
		{
			get => GetProperty(ref _combatExit);
			set => SetProperty(ref _combatExit, value);
		}

		[Ordinal(6)] 
		[RED("targetLost")] 
		public CName TargetLost
		{
			get => GetProperty(ref _targetLost);
			set => SetProperty(ref _targetLost, value);
		}

		[Ordinal(7)] 
		[RED("idle")] 
		public CName Idle
		{
			get => GetProperty(ref _idle);
			set => SetProperty(ref _idle, value);
		}

		[Ordinal(8)] 
		[RED("initialReaction")] 
		public CName InitialReaction
		{
			get => GetProperty(ref _initialReaction);
			set => SetProperty(ref _initialReaction, value);
		}

		[Ordinal(9)] 
		[RED("investigationIgnore")] 
		public CName InvestigationIgnore
		{
			get => GetProperty(ref _investigationIgnore);
			set => SetProperty(ref _investigationIgnore, value);
		}

		[Ordinal(10)] 
		[RED("noClearShot")] 
		public CName NoClearShot
		{
			get => GetProperty(ref _noClearShot);
			set => SetProperty(ref _noClearShot, value);
		}

		[Ordinal(11)] 
		[RED("targetComplies")] 
		public CName TargetComplies
		{
			get => GetProperty(ref _targetComplies);
			set => SetProperty(ref _targetComplies, value);
		}

		[Ordinal(12)] 
		[RED("lookForIntruder")] 
		public CName LookForIntruder
		{
			get => GetProperty(ref _lookForIntruder);
			set => SetProperty(ref _lookForIntruder, value);
		}

		[Ordinal(13)] 
		[RED("droneDestroyed")] 
		public CName DroneDestroyed
		{
			get => GetProperty(ref _droneDestroyed);
			set => SetProperty(ref _droneDestroyed, value);
		}

		[Ordinal(14)] 
		[RED("droneDefeated")] 
		public CName DroneDefeated
		{
			get => GetProperty(ref _droneDefeated);
			set => SetProperty(ref _droneDefeated, value);
		}

		[Ordinal(15)] 
		[RED("commandHolsterWeapon")] 
		public CName CommandHolsterWeapon
		{
			get => GetProperty(ref _commandHolsterWeapon);
			set => SetProperty(ref _commandHolsterWeapon, value);
		}

		[Ordinal(16)] 
		[RED("commandLeaveArea")] 
		public CName CommandLeaveArea
		{
			get => GetProperty(ref _commandLeaveArea);
			set => SetProperty(ref _commandLeaveArea, value);
		}

		[Ordinal(17)] 
		[RED("finalWarning")] 
		public CName FinalWarning
		{
			get => GetProperty(ref _finalWarning);
			set => SetProperty(ref _finalWarning, value);
		}

		[Ordinal(18)] 
		[RED("playDistance")] 
		public CFloat PlayDistance
		{
			get => GetProperty(ref _playDistance);
			set => SetProperty(ref _playDistance, value);
		}

		[Ordinal(19)] 
		[RED("decorators")] 
		public CArray<CName> Decorators
		{
			get => GetProperty(ref _decorators);
			set => SetProperty(ref _decorators, value);
		}

		public audioDroneMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
