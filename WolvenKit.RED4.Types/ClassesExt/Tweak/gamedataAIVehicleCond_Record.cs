
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIVehicleCond_Record
	{
		[RED("activePassangers")]
		[REDProperty(IsIgnored = true)]
		public Vector2 ActivePassangers
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("currentSpeed")]
		[REDProperty(IsIgnored = true)]
		public Vector2 CurrentSpeed
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("driverCheck")]
		[REDProperty(IsIgnored = true)]
		public CInt32 DriverCheck
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("freeSlots")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> FreeSlots
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("hasTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> HasTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("vehicle")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vehicle
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
