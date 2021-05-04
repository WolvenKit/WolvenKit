using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveAllStatusEffectOfTypeEvent : redEvent
	{
		private CEnum<gamedataStatusEffectType> _statusEffectType;

		[Ordinal(0)] 
		[RED("statusEffectType")] 
		public CEnum<gamedataStatusEffectType> StatusEffectType
		{
			get => GetProperty(ref _statusEffectType);
			set => SetProperty(ref _statusEffectType, value);
		}

		public RemoveAllStatusEffectOfTypeEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
