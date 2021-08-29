using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SBaseDeviceOperationData : RedBaseClass
	{
		private CFloat _delay;
		private CBool _resetDelay;
		private CBool _executeOnce;
		private CBool _isEnabled;
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
		private CBool _disableDevice;
		private CArray<SToggleOperationData> _toggleOperations;
		private CInt32 _id;
		private gameDelayID _delayID;
		private CBool _isDelayActive;

		[Ordinal(0)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		[Ordinal(1)] 
		[RED("resetDelay")] 
		public CBool ResetDelay
		{
			get => GetProperty(ref _resetDelay);
			set => SetProperty(ref _resetDelay, value);
		}

		[Ordinal(2)] 
		[RED("executeOnce")] 
		public CBool ExecuteOnce
		{
			get => GetProperty(ref _executeOnce);
			set => SetProperty(ref _executeOnce, value);
		}

		[Ordinal(3)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(4)] 
		[RED("transformAnimations")] 
		public CArray<STransformAnimationData> TransformAnimations
		{
			get => GetProperty(ref _transformAnimations);
			set => SetProperty(ref _transformAnimations, value);
		}

		[Ordinal(5)] 
		[RED("VFXs")] 
		public CArray<SVFXOperationData> VFXs
		{
			get => GetProperty(ref _vFXs);
			set => SetProperty(ref _vFXs, value);
		}

		[Ordinal(6)] 
		[RED("SFXs")] 
		public CArray<SSFXOperationData> SFXs
		{
			get => GetProperty(ref _sFXs);
			set => SetProperty(ref _sFXs, value);
		}

		[Ordinal(7)] 
		[RED("facts")] 
		public CArray<SFactOperationData> Facts
		{
			get => GetProperty(ref _facts);
			set => SetProperty(ref _facts, value);
		}

		[Ordinal(8)] 
		[RED("components")] 
		public CArray<SComponentOperationData> Components
		{
			get => GetProperty(ref _components);
			set => SetProperty(ref _components, value);
		}

		[Ordinal(9)] 
		[RED("stims")] 
		public CArray<SStimOperationData> Stims
		{
			get => GetProperty(ref _stims);
			set => SetProperty(ref _stims, value);
		}

		[Ordinal(10)] 
		[RED("statusEffects")] 
		public CArray<SStatusEffectOperationData> StatusEffects
		{
			get => GetProperty(ref _statusEffects);
			set => SetProperty(ref _statusEffects, value);
		}

		[Ordinal(11)] 
		[RED("damages")] 
		public CArray<SDamageOperationData> Damages
		{
			get => GetProperty(ref _damages);
			set => SetProperty(ref _damages, value);
		}

		[Ordinal(12)] 
		[RED("items")] 
		public CArray<SInventoryOperationData> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		[Ordinal(13)] 
		[RED("teleport")] 
		public STeleportOperationData Teleport
		{
			get => GetProperty(ref _teleport);
			set => SetProperty(ref _teleport, value);
		}

		[Ordinal(14)] 
		[RED("meshesAppearence")] 
		public CName MeshesAppearence
		{
			get => GetProperty(ref _meshesAppearence);
			set => SetProperty(ref _meshesAppearence, value);
		}

		[Ordinal(15)] 
		[RED("playerWorkspot")] 
		public SWorkspotData PlayerWorkspot
		{
			get => GetProperty(ref _playerWorkspot);
			set => SetProperty(ref _playerWorkspot, value);
		}

		[Ordinal(16)] 
		[RED("disableDevice")] 
		public CBool DisableDevice
		{
			get => GetProperty(ref _disableDevice);
			set => SetProperty(ref _disableDevice, value);
		}

		[Ordinal(17)] 
		[RED("toggleOperations")] 
		public CArray<SToggleOperationData> ToggleOperations
		{
			get => GetProperty(ref _toggleOperations);
			set => SetProperty(ref _toggleOperations, value);
		}

		[Ordinal(18)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(19)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get => GetProperty(ref _delayID);
			set => SetProperty(ref _delayID, value);
		}

		[Ordinal(20)] 
		[RED("isDelayActive")] 
		public CBool IsDelayActive
		{
			get => GetProperty(ref _isDelayActive);
			set => SetProperty(ref _isDelayActive, value);
		}
	}
}
