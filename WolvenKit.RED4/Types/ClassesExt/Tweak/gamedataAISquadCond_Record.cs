
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISquadCond_Record
	{
		[RED("hasTickets")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> HasTickets
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("ticketsConditionCheck")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> TicketsConditionCheck
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
