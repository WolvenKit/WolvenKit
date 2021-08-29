using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileProjectilePreviewEvent : gameprojectileSpawnerPreviewEvent
	{
		private Transform _visualOffset;

		[Ordinal(1)] 
		[RED("visualOffset")] 
		public Transform VisualOffset
		{
			get => GetProperty(ref _visualOffset);
			set => SetProperty(ref _visualOffset, value);
		}
	}
}
