using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseCodexLinkController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("linkImage")] 
		public inkImageWidgetReference LinkImage
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("linkLabel")] 
		public inkTextWidgetReference LinkLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("inputContainer")] 
		public inkWidgetReference InputContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(5)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BaseCodexLinkController()
		{
			LinkImage = new inkImageWidgetReference();
			LinkLabel = new inkTextWidgetReference();
			InputContainer = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
