
namespace WolvenKit.RED4.Types
{
	public partial class gamedataDriveHelper_Record
	{
		[RED("type")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Type
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
