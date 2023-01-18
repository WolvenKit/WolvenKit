
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAINPCTypeCond_Record
	{
		[RED("allowedNPCTypes")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> AllowedNPCTypes
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("deviceState")]
		[REDProperty(IsIgnored = true)]
		public CInt32 DeviceState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("isFollower")]
		[REDProperty(IsIgnored = true)]
		public CInt32 IsFollower
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("visualTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> VisualTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
