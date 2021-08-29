using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISetHealthRegenerationState : AIbehaviortaskScript
	{
		private CBool _healthRegeneration;

		[Ordinal(0)] 
		[RED("healthRegeneration")] 
		public CBool HealthRegeneration
		{
			get => GetProperty(ref _healthRegeneration);
			set => SetProperty(ref _healthRegeneration, value);
		}
	}
}
