using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckCurrentStatusEffect : AIStatusEffectCondition
	{
		private CEnum<gamedataStatusEffectType> _statusEffectTypeToCompare;
		private CName _statusEffectTagToCompare;

		[Ordinal(0)] 
		[RED("statusEffectTypeToCompare")] 
		public CEnum<gamedataStatusEffectType> StatusEffectTypeToCompare
		{
			get => GetProperty(ref _statusEffectTypeToCompare);
			set => SetProperty(ref _statusEffectTypeToCompare, value);
		}

		[Ordinal(1)] 
		[RED("statusEffectTagToCompare")] 
		public CName StatusEffectTagToCompare
		{
			get => GetProperty(ref _statusEffectTagToCompare);
			set => SetProperty(ref _statusEffectTagToCompare, value);
		}

		public CheckCurrentStatusEffect(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
