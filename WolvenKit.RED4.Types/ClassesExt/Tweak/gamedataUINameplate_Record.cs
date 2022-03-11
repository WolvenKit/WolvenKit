
namespace WolvenKit.RED4.Types
{
	public partial class gamedataUINameplate_Record
	{
		[RED("enabled")]
		[REDProperty(IsIgnored = true)]
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("position")]
		[REDProperty(IsIgnored = true)]
		public Vector3 Position
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("slot")]
		[REDProperty(IsIgnored = true)]
		public CName Slot
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("type")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Type
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
