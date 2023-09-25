using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EntityAttachementComponentPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("pendingChildAttachements")] 
		public CArray<EntityAttachementData> PendingChildAttachements
		{
			get => GetPropertyValue<CArray<EntityAttachementData>>();
			set => SetPropertyValue<CArray<EntityAttachementData>>(value);
		}

		public EntityAttachementComponentPS()
		{
			PendingChildAttachements = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
