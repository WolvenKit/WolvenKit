
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleClearCoatOverrides_Record
	{
		[RED("coatFresnelBias")]
		[REDProperty(IsIgnored = true)]
		public CFloat CoatFresnelBias
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("coatSpecularColor")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> CoatSpecularColor
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("coatTintFresnelBias")]
		[REDProperty(IsIgnored = true)]
		public CFloat CoatTintFresnelBias
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("coatTintFwd")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> CoatTintFwd
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("coatTintSide")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> CoatTintSide
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("opacity")]
		[REDProperty(IsIgnored = true)]
		public CFloat Opacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
