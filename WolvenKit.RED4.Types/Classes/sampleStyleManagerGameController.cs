using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class sampleStyleManagerGameController : gameuiWidgetGameController
	{
		private redResourceReferenceScriptToken _stylePath1;
		private redResourceReferenceScriptToken _stylePath2;
		private inkWidgetReference _content;

		[Ordinal(2)] 
		[RED("stylePath1")] 
		public redResourceReferenceScriptToken StylePath1
		{
			get => GetProperty(ref _stylePath1);
			set => SetProperty(ref _stylePath1, value);
		}

		[Ordinal(3)] 
		[RED("stylePath2")] 
		public redResourceReferenceScriptToken StylePath2
		{
			get => GetProperty(ref _stylePath2);
			set => SetProperty(ref _stylePath2, value);
		}

		[Ordinal(4)] 
		[RED("content")] 
		public inkWidgetReference Content
		{
			get => GetProperty(ref _content);
			set => SetProperty(ref _content, value);
		}
	}
}
