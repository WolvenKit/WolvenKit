using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemModeGridContainer : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _scrollControllerWidget;
		private inkWidgetReference _sliderWidget;
		private inkWidgetReference _itemsGridWidget;
		private inkCompoundWidgetReference _filterGridWidget;
		private inkWidgetReference _f_eyesTexture;
		private inkWidgetReference _f_systemReplacementTexture;
		private inkWidgetReference _f_handsTexture;
		private inkWidgetReference _m_eyesTexture;
		private inkWidgetReference _m_systemReplacementTexture;
		private inkWidgetReference _m_handsTexture;
		private CHandle<inkanimProxy> _outroAnimation;

		[Ordinal(1)] 
		[RED("scrollControllerWidget")] 
		public inkCompoundWidgetReference ScrollControllerWidget
		{
			get => GetProperty(ref _scrollControllerWidget);
			set => SetProperty(ref _scrollControllerWidget, value);
		}

		[Ordinal(2)] 
		[RED("sliderWidget")] 
		public inkWidgetReference SliderWidget
		{
			get => GetProperty(ref _sliderWidget);
			set => SetProperty(ref _sliderWidget, value);
		}

		[Ordinal(3)] 
		[RED("itemsGridWidget")] 
		public inkWidgetReference ItemsGridWidget
		{
			get => GetProperty(ref _itemsGridWidget);
			set => SetProperty(ref _itemsGridWidget, value);
		}

		[Ordinal(4)] 
		[RED("filterGridWidget")] 
		public inkCompoundWidgetReference FilterGridWidget
		{
			get => GetProperty(ref _filterGridWidget);
			set => SetProperty(ref _filterGridWidget, value);
		}

		[Ordinal(5)] 
		[RED("F_eyesTexture")] 
		public inkWidgetReference F_eyesTexture
		{
			get => GetProperty(ref _f_eyesTexture);
			set => SetProperty(ref _f_eyesTexture, value);
		}

		[Ordinal(6)] 
		[RED("F_systemReplacementTexture")] 
		public inkWidgetReference F_systemReplacementTexture
		{
			get => GetProperty(ref _f_systemReplacementTexture);
			set => SetProperty(ref _f_systemReplacementTexture, value);
		}

		[Ordinal(7)] 
		[RED("F_handsTexture")] 
		public inkWidgetReference F_handsTexture
		{
			get => GetProperty(ref _f_handsTexture);
			set => SetProperty(ref _f_handsTexture, value);
		}

		[Ordinal(8)] 
		[RED("M_eyesTexture")] 
		public inkWidgetReference M_eyesTexture
		{
			get => GetProperty(ref _m_eyesTexture);
			set => SetProperty(ref _m_eyesTexture, value);
		}

		[Ordinal(9)] 
		[RED("M_systemReplacementTexture")] 
		public inkWidgetReference M_systemReplacementTexture
		{
			get => GetProperty(ref _m_systemReplacementTexture);
			set => SetProperty(ref _m_systemReplacementTexture, value);
		}

		[Ordinal(10)] 
		[RED("M_handsTexture")] 
		public inkWidgetReference M_handsTexture
		{
			get => GetProperty(ref _m_handsTexture);
			set => SetProperty(ref _m_handsTexture, value);
		}

		[Ordinal(11)] 
		[RED("outroAnimation")] 
		public CHandle<inkanimProxy> OutroAnimation
		{
			get => GetProperty(ref _outroAnimation);
			set => SetProperty(ref _outroAnimation, value);
		}

		public ItemModeGridContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
