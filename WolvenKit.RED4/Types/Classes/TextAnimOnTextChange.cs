using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TextAnimOnTextChange : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("textField")] 
		public inkTextWidgetReference TextField
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("BlinkAnim")] 
		public CHandle<inkanimDefinition> BlinkAnim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(4)] 
		[RED("ScaleAnim")] 
		public CHandle<inkanimDefinition> ScaleAnim
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(5)] 
		[RED("bufferedValue")] 
		public CString BufferedValue
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public TextAnimOnTextChange()
		{
			TextField = new inkTextWidgetReference();
			AnimationName = "default";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
