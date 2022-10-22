
namespace WolvenKit.RED4.Types
{
	public partial class gamedataHitPrereq_Record
	{
		[RED("callbackType")]
		[REDProperty(IsIgnored = true)]
		public CString CallbackType
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("conditions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Conditions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("isSynchronous")]
		[REDProperty(IsIgnored = true)]
		public CBool IsSynchronous
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("pipelineStage")]
		[REDProperty(IsIgnored = true)]
		public CString PipelineStage
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
