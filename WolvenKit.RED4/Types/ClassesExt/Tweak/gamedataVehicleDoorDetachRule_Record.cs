
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleDoorDetachRule_Record
	{
		[RED("componentToQuery")]
		[REDProperty(IsIgnored = true)]
		public CName ComponentToQuery
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("doorEnumIndex")]
		[REDProperty(IsIgnored = true)]
		public CInt32 DoorEnumIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("partsToDetach")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> PartsToDetach
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
