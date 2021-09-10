using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIEnemyPushedToSquad : AIAIEvent
	{
		[Ordinal(2)] 
		[RED("threat")] 
		public CWeakHandle<entEntity> Threat
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}
	}
}
