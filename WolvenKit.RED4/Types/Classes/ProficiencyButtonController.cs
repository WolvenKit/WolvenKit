using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ProficiencyButtonController : inkButtonController
	{
		[Ordinal(10)] 
		[RED("labelText")] 
		public inkTextWidgetReference LabelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("levelText")] 
		public inkTextWidgetReference LevelText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("frameHovered")] 
		public inkWidgetReference FrameHovered
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("transparencyAnimationProxy")] 
		public CHandle<inkanimProxy> TransparencyAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(14)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ProficiencyButtonController()
		{
			LabelText = new inkTextWidgetReference();
			LevelText = new inkTextWidgetReference();
			FrameHovered = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
