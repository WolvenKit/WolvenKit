
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISquadParams_Record
	{
		[RED("allTickets")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> AllTickets
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("overridenTickets")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> OverridenTickets
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("prohibitedTickets")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ProhibitedTickets
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
