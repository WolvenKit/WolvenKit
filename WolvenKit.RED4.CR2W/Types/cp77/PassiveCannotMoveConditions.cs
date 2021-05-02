using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassiveCannotMoveConditions : PassiveAutonomousCondition
	{
		private CUInt32 _statusEffectRemovedId;

		[Ordinal(0)] 
		[RED("statusEffectRemovedId")] 
		public CUInt32 StatusEffectRemovedId
		{
			get => GetProperty(ref _statusEffectRemovedId);
			set => SetProperty(ref _statusEffectRemovedId, value);
		}

		public PassiveCannotMoveConditions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
