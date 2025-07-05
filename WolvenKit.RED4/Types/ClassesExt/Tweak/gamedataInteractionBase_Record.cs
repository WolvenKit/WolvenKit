
namespace WolvenKit.RED4.Types
{
	public partial class gamedataInteractionBase_Record
	{
		[RED("action")]
		[REDProperty(IsIgnored = true)]
		public CString Action
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("caption")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper Caption
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("captionIcon")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CaptionIcon
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("description")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper Description
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CString Name
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("prereqID")]
		[REDProperty(IsIgnored = true)]
		public CString PrereqID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
