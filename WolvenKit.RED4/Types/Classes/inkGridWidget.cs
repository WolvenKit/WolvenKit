using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkGridWidget : inkCompoundWidget
	{
		[Ordinal(23)] 
		[RED("orientation")] 
		public CEnum<inkEOrientation> Orientation
		{
			get => GetPropertyValue<CEnum<inkEOrientation>>();
			set => SetPropertyValue<CEnum<inkEOrientation>>(value);
		}

		[Ordinal(24)] 
		[RED("childPadding")] 
		public inkMargin ChildPadding
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(25)] 
		[RED("childSizeStep")] 
		public Vector2 ChildSizeStep
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public inkGridWidget()
		{
			ChildPadding = new inkMargin();
			ChildSizeStep = new Vector2();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
