using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ClaymoreMine : gameweaponObject
	{
		[Ordinal(66)] 
		[RED("visualComponent")] 
		public CHandle<entMeshComponent> VisualComponent
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(67)] 
		[RED("triggerAreaIndicator")] 
		public CHandle<entMeshComponent> TriggerAreaIndicator
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(68)] 
		[RED("shootCollision")] 
		public CHandle<entSimpleColliderComponent> ShootCollision
		{
			get => GetPropertyValue<CHandle<entSimpleColliderComponent>>();
			set => SetPropertyValue<CHandle<entSimpleColliderComponent>>(value);
		}

		[Ordinal(69)] 
		[RED("triggerComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> TriggerComponent
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(70)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(71)] 
		[RED("armed")] 
		public CBool Armed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ClaymoreMine()
		{
			Alive = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
