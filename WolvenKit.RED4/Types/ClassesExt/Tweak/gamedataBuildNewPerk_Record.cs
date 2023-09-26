
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBuildNewPerk_Record
	{
		[RED("isActive")]
		[REDProperty(IsIgnored = true)]
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("level")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Level
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("perk")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Perk
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
