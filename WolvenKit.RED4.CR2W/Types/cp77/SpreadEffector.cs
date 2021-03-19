using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpreadEffector : gameEffector
	{
		private wCHandle<gamedataObjectAction_Record> _objectActionRecord;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<gamedataSpreadEffector_Record> _effectorRecord;
		private CBool _spreadToAllTargetsInTheArea;

		[Ordinal(0)] 
		[RED("objectActionRecord")] 
		public wCHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get => GetProperty(ref _objectActionRecord);
			set => SetProperty(ref _objectActionRecord, value);
		}

		[Ordinal(1)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(2)] 
		[RED("effectorRecord")] 
		public CHandle<gamedataSpreadEffector_Record> EffectorRecord
		{
			get => GetProperty(ref _effectorRecord);
			set => SetProperty(ref _effectorRecord, value);
		}

		[Ordinal(3)] 
		[RED("spreadToAllTargetsInTheArea")] 
		public CBool SpreadToAllTargetsInTheArea
		{
			get => GetProperty(ref _spreadToAllTargetsInTheArea);
			set => SetProperty(ref _spreadToAllTargetsInTheArea, value);
		}

		public SpreadEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
