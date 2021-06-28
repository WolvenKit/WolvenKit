using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpreadInitEffector : gameEffector
	{
		private wCHandle<gamedataObjectAction_Record> _objectActionRecord;
		private CHandle<gamedataSpreadInitEffector_Record> _effectorRecord;
		private wCHandle<PlayerPuppet> _player;

		[Ordinal(0)] 
		[RED("objectActionRecord")] 
		public wCHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get => GetProperty(ref _objectActionRecord);
			set => SetProperty(ref _objectActionRecord, value);
		}

		[Ordinal(1)] 
		[RED("effectorRecord")] 
		public CHandle<gamedataSpreadInitEffector_Record> EffectorRecord
		{
			get => GetProperty(ref _effectorRecord);
			set => SetProperty(ref _effectorRecord, value);
		}

		[Ordinal(2)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		public SpreadInitEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
