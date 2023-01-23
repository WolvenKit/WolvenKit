
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRoachRaceBackgroundObject_Record
	{
		[RED("position")]
		[REDProperty(IsIgnored = true)]
		public CFloat Position
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("probability")]
		[REDProperty(IsIgnored = true)]
		public CFloat Probability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
