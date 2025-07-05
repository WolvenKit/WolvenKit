
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAvoidLineOfSightSelectionParameters_Record
	{
		[RED("angle")]
		[REDProperty(IsIgnored = true)]
		public CFloat Angle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("distance")]
		[REDProperty(IsIgnored = true)]
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("height")]
		[REDProperty(IsIgnored = true)]
		public CFloat Height
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("is_paralax")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Is_paralax
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("multiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat Multiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
