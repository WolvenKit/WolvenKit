using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerNotifier_BarbedWire : entTriggerNotifier_Script
	{
		private TweakDBID _attackType;

		[Ordinal(3)] 
		[RED("attackType")] 
		public TweakDBID AttackType
		{
			get => GetProperty(ref _attackType);
			set => SetProperty(ref _attackType, value);
		}

		public TriggerNotifier_BarbedWire(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
