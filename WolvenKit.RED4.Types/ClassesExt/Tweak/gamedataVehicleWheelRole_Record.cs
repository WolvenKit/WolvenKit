
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleWheelRole_Record
	{
		[RED("isDrive")]
		[REDProperty(IsIgnored = true)]
		public CBool IsDrive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isHandBrake")]
		[REDProperty(IsIgnored = true)]
		public CBool IsHandBrake
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isMainBrake")]
		[REDProperty(IsIgnored = true)]
		public CBool IsMainBrake
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
