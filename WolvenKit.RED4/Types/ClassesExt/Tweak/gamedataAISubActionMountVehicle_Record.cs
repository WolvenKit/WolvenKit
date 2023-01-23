
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionMountVehicle_Record
	{
		[RED("mountInstantly")]
		[REDProperty(IsIgnored = true)]
		public CBool MountInstantly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("slot")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Slot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
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
