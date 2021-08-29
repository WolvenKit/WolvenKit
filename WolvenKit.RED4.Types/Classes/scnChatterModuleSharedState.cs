using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnChatterModuleSharedState : ISerializable
	{
		private CArray<CHandle<scnChatter>> _chatterHistory;

		[Ordinal(0)] 
		[RED("chatterHistory")] 
		public CArray<CHandle<scnChatter>> ChatterHistory
		{
			get => GetProperty(ref _chatterHistory);
			set => SetProperty(ref _chatterHistory, value);
		}
	}
}
