using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KerenzikovEvents : TimeDilationEventsTransitions
	{
		private CHandle<gameStatModifierData_Deprecated> _allowMovementModifier;

		[Ordinal(0)] 
		[RED("allowMovementModifier")] 
		public CHandle<gameStatModifierData_Deprecated> AllowMovementModifier
		{
			get => GetProperty(ref _allowMovementModifier);
			set => SetProperty(ref _allowMovementModifier, value);
		}

		public KerenzikovEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
