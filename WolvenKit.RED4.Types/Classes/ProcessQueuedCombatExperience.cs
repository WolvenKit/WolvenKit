using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ProcessQueuedCombatExperience : gamePlayerScriptableSystemRequest
	{
		private entEntityID _entity;

		[Ordinal(1)] 
		[RED("entity")] 
		public entEntityID Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}
	}
}
