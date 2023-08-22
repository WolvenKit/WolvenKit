using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EntityAttachementRequestEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("attachementData")] 
		public EntityAttachementData AttachementData
		{
			get => GetPropertyValue<EntityAttachementData>();
			set => SetPropertyValue<EntityAttachementData>(value);
		}

		public EntityAttachementRequestEvent()
		{
			AttachementData = new EntityAttachementData { AttachementComponentName = "EntityAttachementComponent", OwnerID = new entEntityID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
