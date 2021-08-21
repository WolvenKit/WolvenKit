using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SprintEvents : LocomotionGroundEvents
	{
		private CFloat _previousStimTimeStamp;
		private CHandle<gameStatModifierData_Deprecated> _reloadModifier;
		private CBool _isInSecondSprint;
		private CHandle<gameStatModifierData_Deprecated> _sprintModifier;

		[Ordinal(3)] 
		[RED("previousStimTimeStamp")] 
		public CFloat PreviousStimTimeStamp
		{
			get => GetProperty(ref _previousStimTimeStamp);
			set => SetProperty(ref _previousStimTimeStamp, value);
		}

		[Ordinal(4)] 
		[RED("reloadModifier")] 
		public CHandle<gameStatModifierData_Deprecated> ReloadModifier
		{
			get => GetProperty(ref _reloadModifier);
			set => SetProperty(ref _reloadModifier, value);
		}

		[Ordinal(5)] 
		[RED("isInSecondSprint")] 
		public CBool IsInSecondSprint
		{
			get => GetProperty(ref _isInSecondSprint);
			set => SetProperty(ref _isInSecondSprint, value);
		}

		[Ordinal(6)] 
		[RED("sprintModifier")] 
		public CHandle<gameStatModifierData_Deprecated> SprintModifier
		{
			get => GetProperty(ref _sprintModifier);
			set => SetProperty(ref _sprintModifier, value);
		}

		public SprintEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
