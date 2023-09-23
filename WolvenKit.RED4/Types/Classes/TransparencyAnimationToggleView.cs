using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TransparencyAnimationToggleView : BaseToggleView
	{
		[Ordinal(3)] 
		[RED("AnimationTime")] 
		public CFloat AnimationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("HoverTransparency")] 
		public CFloat HoverTransparency
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("PressTransparency")] 
		public CFloat PressTransparency
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("DefaultTransparency")] 
		public CFloat DefaultTransparency
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("DisabledTransparency")] 
		public CFloat DisabledTransparency
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("AnimationProxies")] 
		public CArray<CHandle<inkanimProxy>> AnimationProxies
		{
			get => GetPropertyValue<CArray<CHandle<inkanimProxy>>>();
			set => SetPropertyValue<CArray<CHandle<inkanimProxy>>>(value);
		}

		[Ordinal(9)] 
		[RED("Targets")] 
		public CArray<inkWidgetReference> Targets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		public TransparencyAnimationToggleView()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
