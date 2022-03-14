
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISecurityCond_Record
	{
		[RED("areaType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AreaType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("invert")]
		[REDProperty(IsIgnored = true)]
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("isConnected")]
		[REDProperty(IsIgnored = true)]
		public CInt32 IsConnected
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
