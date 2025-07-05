using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GrenadePotentialHomingTarget : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entity")] 
		public CWeakHandle<ScriptedPuppet> Entity
		{
			get => GetPropertyValue<CWeakHandle<ScriptedPuppet>>();
			set => SetPropertyValue<CWeakHandle<ScriptedPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("targetSlot")] 
		public CName TargetSlot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public GrenadePotentialHomingTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
