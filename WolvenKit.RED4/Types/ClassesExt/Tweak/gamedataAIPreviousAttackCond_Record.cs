
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIPreviousAttackCond_Record
	{
		[RED("previousAttackDirection")]
		[REDProperty(IsIgnored = true)]
		public CInt32 PreviousAttackDirection
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("previousAttackName")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> PreviousAttackName
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("timeWindow")]
		[REDProperty(IsIgnored = true)]
		public CFloat TimeWindow
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
