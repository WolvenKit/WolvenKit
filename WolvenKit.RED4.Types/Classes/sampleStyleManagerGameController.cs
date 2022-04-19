using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class sampleStyleManagerGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("stylePath1")] 
		public redResourceReferenceScriptToken StylePath1
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(3)] 
		[RED("stylePath2")] 
		public redResourceReferenceScriptToken StylePath2
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(4)] 
		[RED("content")] 
		public inkWidgetReference Content
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public sampleStyleManagerGameController()
		{
			StylePath1 = new();
			StylePath2 = new();
			Content = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
