
namespace WolvenKit.RED4.Types
{
	public partial class gamedataClearLineOfSightCoverSelectionParameters_Record
	{
		[RED("clearLOSDistanceTolerance")]
		[REDProperty(IsIgnored = true)]
		public CFloat ClearLOSDistanceTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("cooldown")]
		[REDProperty(IsIgnored = true)]
		public CFloat Cooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("multiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat Multiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("preferredActionCount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 PreferredActionCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
