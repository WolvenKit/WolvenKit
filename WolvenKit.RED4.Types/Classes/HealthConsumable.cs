using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HealthConsumable : gameCpoPickableItem
	{
		private CHandle<gameinteractionsComponent> _interactionComponent;
		private CHandle<entMeshComponent> _meshComponent;
		private CBool _disappearAfterEquip;
		private CFloat _respawnTime;

		[Ordinal(42)] 
		[RED("interactionComponent")] 
		public CHandle<gameinteractionsComponent> InteractionComponent
		{
			get => GetProperty(ref _interactionComponent);
			set => SetProperty(ref _interactionComponent, value);
		}

		[Ordinal(43)] 
		[RED("meshComponent")] 
		public CHandle<entMeshComponent> MeshComponent
		{
			get => GetProperty(ref _meshComponent);
			set => SetProperty(ref _meshComponent, value);
		}

		[Ordinal(44)] 
		[RED("disappearAfterEquip")] 
		public CBool DisappearAfterEquip
		{
			get => GetProperty(ref _disappearAfterEquip);
			set => SetProperty(ref _disappearAfterEquip, value);
		}

		[Ordinal(45)] 
		[RED("respawnTime")] 
		public CFloat RespawnTime
		{
			get => GetProperty(ref _respawnTime);
			set => SetProperty(ref _respawnTime, value);
		}
	}
}
