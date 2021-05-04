using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSideScrollerMiniGameLogicControllerAdvanced : inkWidgetLogicController
	{
		private CName _playerLibraryName;
		private Vector2 _playerColliderPositionOffset;
		private Vector2 _playerColliderSizeOffset;
		private inkCompoundWidgetReference _gameplayRoot;
		private CFloat _baseSpeed;
		private CArray<inkWidgetReference> _layers;
		private CArray<gameuiSideScrollerCheatCode> _cheatCodes;
		private CArray<CName> _acceptableCheatKeys;

		[Ordinal(1)] 
		[RED("playerLibraryName")] 
		public CName PlayerLibraryName
		{
			get => GetProperty(ref _playerLibraryName);
			set => SetProperty(ref _playerLibraryName, value);
		}

		[Ordinal(2)] 
		[RED("playerColliderPositionOffset")] 
		public Vector2 PlayerColliderPositionOffset
		{
			get => GetProperty(ref _playerColliderPositionOffset);
			set => SetProperty(ref _playerColliderPositionOffset, value);
		}

		[Ordinal(3)] 
		[RED("playerColliderSizeOffset")] 
		public Vector2 PlayerColliderSizeOffset
		{
			get => GetProperty(ref _playerColliderSizeOffset);
			set => SetProperty(ref _playerColliderSizeOffset, value);
		}

		[Ordinal(4)] 
		[RED("gameplayRoot")] 
		public inkCompoundWidgetReference GameplayRoot
		{
			get => GetProperty(ref _gameplayRoot);
			set => SetProperty(ref _gameplayRoot, value);
		}

		[Ordinal(5)] 
		[RED("baseSpeed")] 
		public CFloat BaseSpeed
		{
			get => GetProperty(ref _baseSpeed);
			set => SetProperty(ref _baseSpeed, value);
		}

		[Ordinal(6)] 
		[RED("layers")] 
		public CArray<inkWidgetReference> Layers
		{
			get => GetProperty(ref _layers);
			set => SetProperty(ref _layers, value);
		}

		[Ordinal(7)] 
		[RED("cheatCodes")] 
		public CArray<gameuiSideScrollerCheatCode> CheatCodes
		{
			get => GetProperty(ref _cheatCodes);
			set => SetProperty(ref _cheatCodes, value);
		}

		[Ordinal(8)] 
		[RED("acceptableCheatKeys")] 
		public CArray<CName> AcceptableCheatKeys
		{
			get => GetProperty(ref _acceptableCheatKeys);
			set => SetProperty(ref _acceptableCheatKeys, value);
		}

		public gameuiSideScrollerMiniGameLogicControllerAdvanced(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
