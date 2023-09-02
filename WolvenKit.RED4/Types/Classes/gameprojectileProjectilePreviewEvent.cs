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
			VisualOffset = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
