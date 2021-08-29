using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AimAssistModule : HUDModule
	{
		private CArray<CHandle<AimAssist>> _activeAssists;

		[Ordinal(3)] 
		[RED("activeAssists")] 
		public CArray<CHandle<AimAssist>> ActiveAssists
		{
			get => GetProperty(ref _activeAssists);
			set => SetProperty(ref _activeAssists, value);
		}
	}
}
