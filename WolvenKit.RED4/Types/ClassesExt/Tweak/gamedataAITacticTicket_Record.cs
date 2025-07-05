
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAITacticTicket_Record
	{
		[RED("offensiveTactic")]
		[REDProperty(IsIgnored = true)]
		public CBool OffensiveTactic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("sectors")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Sectors
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("tacticTimeout")]
		[REDProperty(IsIgnored = true)]
		public CFloat TacticTimeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
