using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkScrollAreaWidget : inkCompoundWidget
	{
		[Ordinal(23)] 
		[RED("horizontalScrolling")] 
		public CFloat HorizontalScrolling
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("verticalScrolling")] 
		public CFloat VerticalScrolling
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("constrainContentPosition")] 
		public CBool ConstrainContentPosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("fitToContentDirection")] 
		public CEnum<inkFitToContentDirection> FitToContentDirection
		{
			get => GetPropertyValue<CEnum<inkFitToContentDirection>>();
			set => SetPropertyValue<CEnum<inkFitToContentDirection>>(value);
		}

		[Ordinal(27)] 
		[RED("useInternalMask")] 
		public CBool UseInternalMask
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkScrollAreaWidget()
		{
			UseInternalMask = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
