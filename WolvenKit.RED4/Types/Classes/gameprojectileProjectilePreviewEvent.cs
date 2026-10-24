using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileProjectilePreviewEvent : gameprojectileSpawnerPreviewEvent
	{
		[Ordinal(1)] 
		[RED("visualOffset")] 
		public Transform VisualOffset
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		public gameprojectileProjectilePreviewEvent()
		{
			VisualOffset = new Transform();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
