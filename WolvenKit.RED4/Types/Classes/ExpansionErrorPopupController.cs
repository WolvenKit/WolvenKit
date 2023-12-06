using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExpansionErrorPopupController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("errorCodeText")] 
		public inkTextWidgetReference ErrorCodeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("closeButtonRef")] 
		public inkWidgetReference CloseButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("outroAnimationName")] 
		public CName OutroAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("data")] 
		public CHandle<ExpansionErrorPopuppData> Data
		{
			get => GetPropertyValue<CHandle<ExpansionErrorPopuppData>>();
			set => SetPropertyValue<CHandle<ExpansionErrorPopuppData>>(value);
		}

		[Ordinal(9)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public ExpansionErrorPopupController()
		{
			Title = new inkTextWidgetReference();
			Description = new inkTextWidgetReference();
			ErrorCodeText = new inkTextWidgetReference();
			CloseButtonRef = new inkWidgetReference();
			IntroAnimationName = "intro";
			OutroAnimationName = "outro";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
