
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIInTacticPositionCond_Record
	{
		[RED("tactics")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Tactics
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
