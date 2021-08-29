using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questMappinManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<gameJournalPath> _path;
		private CBool _disablePreviousMappins;

		[Ordinal(2)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		[Ordinal(3)] 
		[RED("disablePreviousMappins")] 
		public CBool DisablePreviousMappins
		{
			get => GetProperty(ref _disablePreviousMappins);
			set => SetProperty(ref _disablePreviousMappins, value);
		}
	}
}
