
namespace WolvenKit.RED4.Types
{
	public partial class gamedataOwnerAngleCoverSelectionParameters_Record
	{
		[RED("maxAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("minAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat MinAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
