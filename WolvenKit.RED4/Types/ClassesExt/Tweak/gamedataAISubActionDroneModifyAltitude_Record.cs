
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionDroneModifyAltitude_Record
	{
		[RED("altitudeOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat AltitudeOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
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
