
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItemDropSettings_Record
	{
		[RED("desiredAngularVelocity")]
		[REDProperty(IsIgnored = true)]
		public CFloat DesiredAngularVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("desiredInitialRotation")]
		[REDProperty(IsIgnored = true)]
		public CFloat DesiredInitialRotation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
