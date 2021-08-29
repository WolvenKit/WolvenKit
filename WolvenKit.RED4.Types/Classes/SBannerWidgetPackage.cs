using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SBannerWidgetPackage : SWidgetPackage
	{
		private CString _title;
		private CString _description;
		private redResourceReferenceScriptToken _content;

		[Ordinal(17)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(18)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(19)] 
		[RED("content")] 
		public redResourceReferenceScriptToken Content
		{
			get => GetProperty(ref _content);
			set => SetProperty(ref _content, value);
		}
	}
}
