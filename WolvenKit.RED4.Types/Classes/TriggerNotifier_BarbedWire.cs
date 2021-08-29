using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TriggerNotifier_BarbedWire : entTriggerNotifier_Script
	{
		private TweakDBID _attackType;

		[Ordinal(3)] 
		[RED("attackType")] 
		public TweakDBID AttackType
		{
			get => GetProperty(ref _attackType);
			set => SetProperty(ref _attackType, value);
		}
	}
}
