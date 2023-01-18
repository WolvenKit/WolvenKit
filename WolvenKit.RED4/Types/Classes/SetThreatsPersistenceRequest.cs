using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetThreatsPersistenceRequest : AIAIEvent
	{
		[Ordinal(2)] 
		[RED("et")] 
		public CWeakHandle<entEntity> Et
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(3)] 
		[RED("isPersistent")] 
		public CBool IsPersistent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetThreatsPersistenceRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
