using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TransparencyAnimationButtonView : BaseButtonView
	{
		[Ordinal(2)] 
		[RED("AnimationTime")] 
		public CFloat AnimationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("HoverTransparency")] 
		public CFloat HoverTransparency
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("PressTransparency")] 
		public CFloat PressTransparency
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("DefaultTransparency")] 
		public CFloat DefaultTransparency
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("DisabledTransparency")] 
		public CFloat DisabledTransparency
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("AnimationProxies")] 
		public CArray<CHandle<inkanimProxy>> AnimationProxies
		{
			get => GetPropertyValue<CArray<CHandle<inkanimProxy>>>();
			set => SetPropertyValue<CArray<CHandle<inkanimProxy>>>(value);
		}

		[Ordinal(8)] 
		[RED("Targets")] 
		public CArray<inkWidgetReference> Targets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		public TransparencyAnimationButtonView()
		{
			AnimationTime = 0.100000F;
			HoverTransparency = 0.200000F;
			PressTransparency = 0.400000F;
			AnimationProxies = new();
			Targets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
