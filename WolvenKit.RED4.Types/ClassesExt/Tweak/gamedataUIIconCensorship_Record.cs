
namespace WolvenKit.RED4.Types
{
	public partial class gamedataUIIconCensorship_Record
	{
		[RED("censoredIcon")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CensoredIcon
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("censorFlags")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> CensorFlags
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("replacer")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Replacer
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
