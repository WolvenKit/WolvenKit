using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSquadMemberComponentPS : gameComponentPS
	{
		private CArray<gameSquadMemberDataEntry> _entries;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<gameSquadMemberDataEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
