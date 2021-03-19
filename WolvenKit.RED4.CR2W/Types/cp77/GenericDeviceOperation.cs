using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericDeviceOperation : DeviceOperationBase
	{
		private CArray<SVfxInstanceData> _fxInstances;
		private CArray<STransformAnimationData> _transformAnimations;
		private CArray<SVFXOperationData> _vFXs;
		private CArray<SSFXOperationData> _sFXs;
		private CArray<SFactOperationData> _facts;
		private CArray<SComponentOperationData> _components;
		private CArray<SStimOperationData> _stims;
		private CArray<SStatusEffectOperationData> _statusEffects;
		private CArray<SDamageOperationData> _damages;
		private CArray<SInventoryOperationData> _items;
		private STeleportOperationData _teleport;
		private CName _meshesAppearence;
		private SWorkspotData _playerWorkspot;

		[Ordinal(5)] 
		[RED("fxInstances")] 
		public CArray<SVfxInstanceData> FxInstances
		{
			get => GetProperty(ref _fxInstances);
			set => SetProperty(ref _fxInstances, value);
		}

		[Ordinal(6)] 
		[RED("transformAnimations")] 
		public CArray<STransformAnimationData> TransformAnimations
		{
			get => GetProperty(ref _transformAnimations);
			set => SetProperty(ref _transformAnimations, value);
		}

		[Ordinal(7)] 
		[RED("VFXs")] 
		public CArray<SVFXOperationData> VFXs
		{
			get => GetProperty(ref _vFXs);
			set => SetProperty(ref _vFXs, value);
		}

		[Ordinal(8)] 
		[RED("SFXs")] 
		public CArray<SSFXOperationData> SFXs
		{
			get => GetProperty(ref _sFXs);
			set => SetProperty(ref _sFXs, value);
		}

		[Ordinal(9)] 
		[RED("facts")] 
		public CArray<SFactOperationData> Facts
		{
			get => GetProperty(ref _facts);
			set => SetProperty(ref _facts, value);
		}

		[Ordinal(10)] 
		[RED("components")] 
		public CArray<SComponentOperationData> Components
		{
			get => GetProperty(ref _components);
			set => SetProperty(ref _components, value);
		}

		[Ordinal(11)] 
		[RED("stims")] 
		public CArray<SStimOperationData> Stims
		{
			get => GetProperty(ref _stims);
			set => SetProperty(ref _stims, value);
		}

		[Ordinal(12)] 
		[RED("statusEffects")] 
		public CArray<SStatusEffectOperationData> StatusEffects
		{
			get => GetProperty(ref _statusEffects);
			set => SetProperty(ref _statusEffects, value);
		}

		[Ordinal(13)] 
		[RED("damages")] 
		public CArray<SDamageOperationData> Damages
		{
			get => GetProperty(ref _damages);
			set => SetProperty(ref _damages, value);
		}

		[Ordinal(14)] 
		[RED("items")] 
		public CArray<SInventoryOperationData> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		[Ordinal(15)] 
		[RED("teleport")] 
		public STeleportOperationData Teleport
		{
			get => GetProperty(ref _teleport);
			set => SetProperty(ref _teleport, value);
		}

		[Ordinal(16)] 
		[RED("meshesAppearence")] 
		public CName MeshesAppearence
		{
			get => GetProperty(ref _meshesAppearence);
			set => SetProperty(ref _meshesAppearence, value);
		}

		[Ordinal(17)] 
		[RED("playerWorkspot")] 
		public SWorkspotData PlayerWorkspot
		{
			get => GetProperty(ref _playerWorkspot);
			set => SetProperty(ref _playerWorkspot, value);
		}

		public GenericDeviceOperation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
