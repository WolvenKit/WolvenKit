using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ProcessQueuedCombatExperience : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("entity")] 
		public entEntityID Entity
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public ProcessQueuedCombatExperience()
		{
			Entity = new();
		}
	}
}
