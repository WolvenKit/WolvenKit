using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileSpawnerPreviewEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("previewActive")] 
		public CBool PreviewActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameprojectileSpawnerPreviewEvent()
		{
			PreviewActive = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
