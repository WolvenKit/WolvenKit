using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EntityAttachementComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("parentAttachementData")] 
		public EntityAttachementData ParentAttachementData
		{
			get => GetPropertyValue<EntityAttachementData>();
			set => SetPropertyValue<EntityAttachementData>(value);
		}

		public EntityAttachementComponent()
		{
			ParentAttachementData = new() { AttachementComponentName = "EntityAttachementComponent", OwnerID = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
