using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPreloadFX_NodeTypeParams : RedBaseClass
	{
		private CBool _preload;
		private gameEntityReference _objectRef;
		private CBool _isPlayer;
		private CName _effectName;

		[Ordinal(0)] 
		[RED("preload")] 
		public CBool Preload
		{
			get => GetProperty(ref _preload);
			set => SetProperty(ref _preload, value);
		}

		[Ordinal(1)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(2)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(3)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetProperty(ref _effectName);
			set => SetProperty(ref _effectName, value);
		}

		public questPreloadFX_NodeTypeParams()
		{
			_preload = true;
		}
	}
}
