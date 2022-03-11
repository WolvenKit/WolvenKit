
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSpreadInitEffector_Record
	{
		[RED("bonusJumps")]
		[REDProperty(IsIgnored = true)]
		public CInt32 BonusJumps
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("objectAction")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ObjectAction
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("spreadCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 SpreadCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("spreadDistance")]
		[REDProperty(IsIgnored = true)]
		public CInt32 SpreadDistance
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
