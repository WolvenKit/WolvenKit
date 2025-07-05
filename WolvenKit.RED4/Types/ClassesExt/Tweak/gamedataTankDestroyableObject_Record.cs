
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTankDestroyableObject_Record
	{
		[RED("dropProbability")]
		[REDProperty(IsIgnored = true)]
		public CFloat DropProbability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("health")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Health
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("rammingInvincibilityTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat RammingInvincibilityTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("score")]
		[REDProperty(IsIgnored = true)]
		public CFloat Score
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("scoreMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat ScoreMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
