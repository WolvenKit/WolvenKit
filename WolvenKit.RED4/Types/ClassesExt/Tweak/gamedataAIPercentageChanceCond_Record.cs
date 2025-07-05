
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIPercentageChanceCond_Record
	{
		[RED("successProbability")]
		[REDProperty(IsIgnored = true)]
		public CInt32 SuccessProbability
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
