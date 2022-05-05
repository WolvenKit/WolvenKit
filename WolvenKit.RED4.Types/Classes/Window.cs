using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Window : Door
	{
		[Ordinal(140)] 
		[RED("soloCollider")] 
		public CHandle<entIComponent> SoloCollider
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(141)] 
		[RED("strongSoloHandle")] 
		public CHandle<entMeshComponent> StrongSoloHandle
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(142)] 
		[RED("duplicateDestruction")] 
		public CBool DuplicateDestruction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public Window()
		{
			ControllerTypeName = "WindowController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
