using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class LookAtPresetBaseEvents : DefaultTransition
	{
		[Ordinal(0)] 
		[RED("lookAtEvents")] 
		public CArray<CHandle<entLookAtAddEvent>> LookAtEvents
		{
			get => GetPropertyValue<CArray<CHandle<entLookAtAddEvent>>>();
			set => SetPropertyValue<CArray<CHandle<entLookAtAddEvent>>>(value);
		}

		[Ordinal(1)] 
		[RED("attachLeft")] 
		public CBool AttachLeft
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("attachRight")] 
		public CBool AttachRight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LookAtPresetBaseEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
