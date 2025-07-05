
namespace WolvenKit.RED4.Types
{
	public partial class gamedataEquipmentMovementSound_Record
	{
		[RED("audioMovementName")]
		[REDProperty(IsIgnored = true)]
		public CName AudioMovementName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("priority")]
		[REDProperty(IsIgnored = true)]
		public CFloat Priority
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
