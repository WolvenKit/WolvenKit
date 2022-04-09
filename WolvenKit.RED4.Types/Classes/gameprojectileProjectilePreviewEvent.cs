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
			VisualOffset = new() { Position = new(), Orientation = new() { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
