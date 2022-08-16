
namespace WolvenKit.RED4.Types
{
	public partial class gamedataLinearAccuracy_Record
	{
		[RED("duration")]
		[REDProperty(IsIgnored = true)]
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
