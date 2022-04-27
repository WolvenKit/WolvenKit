using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadialStatusEffectController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("effectsContainerRef")] 
		public inkCompoundWidgetReference EffectsContainerRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("poolHolderRef")] 
		public inkCompoundWidgetReference PoolHolderRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("effectTemplateRef")] 
		public inkWidgetLibraryReference EffectTemplateRef
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(4)] 
		[RED("maxSize")] 
		public CInt32 MaxSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("effects")] 
		public CArray<CWeakHandle<SingleCooldownManager>> Effects
		{
			get => GetPropertyValue<CArray<CWeakHandle<SingleCooldownManager>>>();
			set => SetPropertyValue<CArray<CWeakHandle<SingleCooldownManager>>>(value);
		}

		public RadialStatusEffectController()
		{
			EffectsContainerRef = new();
			PoolHolderRef = new();
			EffectTemplateRef = new() { WidgetLibrary = new() };
			MaxSize = 8;
			Effects = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
