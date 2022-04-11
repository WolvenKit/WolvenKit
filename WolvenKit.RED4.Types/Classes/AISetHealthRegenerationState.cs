using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISetHealthRegenerationState : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("healthRegeneration")] 
		public CBool HealthRegeneration
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
