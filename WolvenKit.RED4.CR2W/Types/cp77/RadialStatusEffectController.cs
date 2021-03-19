using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadialStatusEffectController : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _effectsContainerRef;
		private inkCompoundWidgetReference _poolHolderRef;
		private inkWidgetLibraryReference _effectTemplateRef;
		private CInt32 _maxSize;
		private CArray<wCHandle<SingleCooldownManager>> _effects;

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
		public CArray<wCHandle<SingleCooldownManager>> Effects
		{
			get => GetProperty(ref _effects);
			set => SetProperty(ref _effects, value);
		}

		public RadialStatusEffectController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
