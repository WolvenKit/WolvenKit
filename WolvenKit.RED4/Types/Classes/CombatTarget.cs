using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CombatTarget : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("puppet")] 
		public CWeakHandle<ScriptedPuppet> Puppet
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("hasTime")] 
		public CBool HasTime
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("highlightTime")] 
		public CFloat HighlightTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CombatTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
