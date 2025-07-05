using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSquadMemberComponentPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<gameSquadMemberDataEntry> Entries
		{
			get => GetPropertyValue<CArray<gameSquadMemberDataEntry>>();
			set => SetPropertyValue<CArray<gameSquadMemberDataEntry>>(value);
		}

		public gameSquadMemberComponentPS()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
