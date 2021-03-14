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
			get
			{
				if (_effectsContainerRef == null)
				{
					_effectsContainerRef = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "effectsContainerRef", cr2w, this);
				}
				return _effectsContainerRef;
			}
			set
			{
				if (_effectsContainerRef == value)
				{
					return;
				}
				_effectsContainerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("poolHolderRef")] 
		public inkCompoundWidgetReference PoolHolderRef
		{
			get
			{
				if (_poolHolderRef == null)
				{
					_poolHolderRef = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "poolHolderRef", cr2w, this);
				}
				return _poolHolderRef;
			}
			set
			{
				if (_poolHolderRef == value)
				{
					return;
				}
				_poolHolderRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("effectTemplateRef")] 
		public inkWidgetLibraryReference EffectTemplateRef
		{
			get
			{
				if (_effectTemplateRef == null)
				{
					_effectTemplateRef = (inkWidgetLibraryReference) CR2WTypeManager.Create("inkWidgetLibraryReference", "effectTemplateRef", cr2w, this);
				}
				return _effectTemplateRef;
			}
			set
			{
				if (_effectTemplateRef == value)
				{
					return;
				}
				_effectTemplateRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maxSize")] 
		public CInt32 MaxSize
		{
			get
			{
				if (_maxSize == null)
				{
					_maxSize = (CInt32) CR2WTypeManager.Create("Int32", "maxSize", cr2w, this);
				}
				return _maxSize;
			}
			set
			{
				if (_maxSize == value)
				{
					return;
				}
				_maxSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("effects")] 
		public CArray<wCHandle<SingleCooldownManager>> Effects
		{
			get
			{
				if (_effects == null)
				{
					_effects = (CArray<wCHandle<SingleCooldownManager>>) CR2WTypeManager.Create("array:whandle:SingleCooldownManager", "effects", cr2w, this);
				}
				return _effects;
			}
			set
			{
				if (_effects == value)
				{
					return;
				}
				_effects = value;
				PropertySet(this);
			}
		}

		public RadialStatusEffectController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
