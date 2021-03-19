using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectExecutor_Spread : gameEffectExecutor_Scripted
	{
		private wCHandle<gamedataObjectAction_Record> _objectActionRecord;
		private wCHandle<entEntity> _prevEntity;
		private wCHandle<PlayerPuppet> _player;
		private CBool _spreadToAllTargetsInTheArea;

		[Ordinal(1)] 
		[RED("objectActionRecord")] 
		public wCHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get => GetProperty(ref _objectActionRecord);
			set => SetProperty(ref _objectActionRecord, value);
		}

		[Ordinal(2)] 
		[RED("prevEntity")] 
		public wCHandle<entEntity> PrevEntity
		{
			get => GetProperty(ref _prevEntity);
			set => SetProperty(ref _prevEntity, value);
		}

		[Ordinal(3)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(4)] 
		[RED("spreadToAllTargetsInTheArea")] 
		public CBool SpreadToAllTargetsInTheArea
		{
			get => GetProperty(ref _spreadToAllTargetsInTheArea);
			set => SetProperty(ref _spreadToAllTargetsInTheArea, value);
		}

		public EffectExecutor_Spread(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
