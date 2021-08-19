using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterLevelUpGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _value;
		private inkTextWidgetReference _proficencyLabel;
		private CUInt32 _stateChangesBlackboardId;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<LevelUpUserData> _data;

		[Ordinal(9)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(10)] 
		[RED("proficencyLabel")] 
		public inkTextWidgetReference ProficencyLabel
		{
			get => GetProperty(ref _proficencyLabel);
			set => SetProperty(ref _proficencyLabel, value);
		}

		[Ordinal(11)] 
		[RED("stateChangesBlackboardId")] 
		public CUInt32 StateChangesBlackboardId
		{
			get => GetProperty(ref _stateChangesBlackboardId);
			set => SetProperty(ref _stateChangesBlackboardId, value);
		}

		[Ordinal(12)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(13)] 
		[RED("data")] 
		public CHandle<LevelUpUserData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public CharacterLevelUpGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
