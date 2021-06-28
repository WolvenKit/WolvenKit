using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckCurrentWoundedState : AIStatusEffectCondition
	{
		private CEnum<EWoundedBodyPart> _woundedTypeToCompare;

		[Ordinal(0)] 
		[RED("woundedTypeToCompare")] 
		public CEnum<EWoundedBodyPart> WoundedTypeToCompare
		{
			get => GetProperty(ref _woundedTypeToCompare);
			set => SetProperty(ref _woundedTypeToCompare, value);
		}

		public CheckCurrentWoundedState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
