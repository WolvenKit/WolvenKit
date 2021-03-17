using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiOnMiniGameStateUpdateEventAdvanced : redEvent
	{
		private CHandle<gameuiSideScrollerMiniGameStateAdvanced> _gameState;
		private CArray<CName> _propertyNames;

		[Ordinal(0)] 
		[RED("gameState")] 
		public CHandle<gameuiSideScrollerMiniGameStateAdvanced> GameState
		{
			get => GetProperty(ref _gameState);
			set => SetProperty(ref _gameState, value);
		}

		[Ordinal(1)] 
		[RED("propertyNames")] 
		public CArray<CName> PropertyNames
		{
			get => GetProperty(ref _propertyNames);
			set => SetProperty(ref _propertyNames, value);
		}

		public gameuiOnMiniGameStateUpdateEventAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
