
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterObject_Record
	{
		[RED("gravity")]
		[REDProperty(IsIgnored = true)]
		public CFloat Gravity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("max_gravity")]
		[REDProperty(IsIgnored = true)]
		public CFloat Max_gravity
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
	}
}
