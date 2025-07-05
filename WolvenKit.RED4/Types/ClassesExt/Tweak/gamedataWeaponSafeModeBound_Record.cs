
namespace WolvenKit.RED4.Types
{
	public partial class gamedataWeaponSafeModeBound_Record
	{
		[RED("pitchMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat PitchMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("pitchMin")]
		[REDProperty(IsIgnored = true)]
		public CFloat PitchMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("yawMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat YawMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("yawMin")]
		[REDProperty(IsIgnored = true)]
		public CFloat YawMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
