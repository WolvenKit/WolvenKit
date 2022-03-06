
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionActivateStrongArmsFX_Record
	{
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
