using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldSaveSanitizationForbiddenAreaNode : worldTriggerAreaNode
	{
		private Vector4 _safeSpotOffset;

		[Ordinal(7)] 
		[RED("safeSpotOffset")] 
		public Vector4 SafeSpotOffset
		{
			get => GetProperty(ref _safeSpotOffset);
			set => SetProperty(ref _safeSpotOffset, value);
		}
	}
}
