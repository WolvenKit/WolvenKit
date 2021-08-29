using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMountEventData : IScriptable
	{
		private CName _slotName;
		private entEntityID _mountParentEntityId;
		private CBool _isInstant;
		private CName _entryAnimName;
		private Transform _initialTransformLS;
		private CBool _setEntityVisibleWhenMountFinish;
		private CBool _removePitchRollRotationOnDismount;
		private CBool _ignoreHLS;
		private CHandle<gameMountEventOptions> _mountEventOptions;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(1)] 
		[RED("mountParentEntityId")] 
		public entEntityID MountParentEntityId
		{
			get => GetProperty(ref _mountParentEntityId);
			set => SetProperty(ref _mountParentEntityId, value);
		}

		[Ordinal(2)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get => GetProperty(ref _isInstant);
			set => SetProperty(ref _isInstant, value);
		}

		[Ordinal(3)] 
		[RED("entryAnimName")] 
		public CName EntryAnimName
		{
			get => GetProperty(ref _entryAnimName);
			set => SetProperty(ref _entryAnimName, value);
		}

		[Ordinal(4)] 
		[RED("initialTransformLS")] 
		public Transform InitialTransformLS
		{
			get => GetProperty(ref _initialTransformLS);
			set => SetProperty(ref _initialTransformLS, value);
		}

		[Ordinal(5)] 
		[RED("setEntityVisibleWhenMountFinish")] 
		public CBool SetEntityVisibleWhenMountFinish
		{
			get => GetProperty(ref _setEntityVisibleWhenMountFinish);
			set => SetProperty(ref _setEntityVisibleWhenMountFinish, value);
		}

		[Ordinal(6)] 
		[RED("removePitchRollRotationOnDismount")] 
		public CBool RemovePitchRollRotationOnDismount
		{
			get => GetProperty(ref _removePitchRollRotationOnDismount);
			set => SetProperty(ref _removePitchRollRotationOnDismount, value);
		}

		[Ordinal(7)] 
		[RED("ignoreHLS")] 
		public CBool IgnoreHLS
		{
			get => GetProperty(ref _ignoreHLS);
			set => SetProperty(ref _ignoreHLS, value);
		}

		[Ordinal(8)] 
		[RED("mountEventOptions")] 
		public CHandle<gameMountEventOptions> MountEventOptions
		{
			get => GetProperty(ref _mountEventOptions);
			set => SetProperty(ref _mountEventOptions, value);
		}
	}
}
