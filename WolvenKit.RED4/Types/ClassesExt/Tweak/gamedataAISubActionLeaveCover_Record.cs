
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionLeaveCover_Record
	{
		[RED("checkExposure")]
		[REDProperty(IsIgnored = true)]
		public CInt32 CheckExposure
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
