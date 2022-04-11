using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TriggerNotifier_BarbedWire : entTriggerNotifier_Script
	{
		[Ordinal(3)] 
		[RED("attackType")] 
		public TweakDBID AttackType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
