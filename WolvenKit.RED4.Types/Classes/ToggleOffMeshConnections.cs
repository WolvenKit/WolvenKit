using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ToggleOffMeshConnections : redEvent
	{
		private CBool _enable;
		private CBool _affectsPlayer;
		private CBool _affectsNPCs;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(1)] 
		[RED("affectsPlayer")] 
		public CBool AffectsPlayer
		{
			get => GetProperty(ref _affectsPlayer);
			set => SetProperty(ref _affectsPlayer, value);
		}

		[Ordinal(2)] 
		[RED("affectsNPCs")] 
		public CBool AffectsNPCs
		{
			get => GetProperty(ref _affectsNPCs);
			set => SetProperty(ref _affectsNPCs, value);
		}
	}
}
