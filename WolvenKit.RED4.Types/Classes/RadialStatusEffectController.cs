using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RadialStatusEffectController : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _effectsContainerRef;
		private inkCompoundWidgetReference _poolHolderRef;
		private inkWidgetLibraryReference _effectTemplateRef;
		private CInt32 _maxSize;
		private CArray<CWeakHandle<SingleCooldownManager>> _effects;

		[Ordinal(1)] 
		[RED("effectsContainerRef")] 
		public inkCompoundWidgetReference EffectsContainerRef
		{
			get => GetProperty(ref _effectsContainerRef);
			set => SetProperty(ref _effectsContainerRef, value);
		}

		[Ordinal(2)] 
		[RED("poolHolderRef")] 
		public inkCompoundWidgetReference PoolHolderRef
		{
			get => GetProperty(ref _poolHolderRef);
			set => SetProperty(ref _poolHolderRef, value);
		}

		[Ordinal(3)] 
		[RED("effectTemplateRef")] 
		public inkWidgetLibraryReference EffectTemplateRef
		{
			get => GetProperty(ref _effectTemplateRef);
			set => SetProperty(ref _effectTemplateRef, value);
		}

		[Ordinal(4)] 
		[RED("maxSize")] 
		public CInt32 MaxSize
		{
			get => GetProperty(ref _maxSize);
			set => SetProperty(ref _maxSize, value);
		}

		[Ordinal(5)] 
		[RED("effects")] 
		public CArray<CWeakHandle<SingleCooldownManager>> Effects
		{
			get => GetProperty(ref _effects);
			set => SetProperty(ref _effects, value);
		}
	}
}
