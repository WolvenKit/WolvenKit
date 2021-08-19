using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerQuickhackData : CVariable
	{
		private wCHandle<gamedataObjectAction_Record> _actionRecord;
		private CInt32 _quality;

		[Ordinal(0)] 
		[RED("actionRecord")] 
		public wCHandle<gamedataObjectAction_Record> ActionRecord
		{
			get => GetProperty(ref _actionRecord);
			set => SetProperty(ref _actionRecord, value);
		}

		[Ordinal(1)] 
		[RED("quality")] 
		public CInt32 Quality
		{
			get => GetProperty(ref _quality);
			set => SetProperty(ref _quality, value);
		}

		public PlayerQuickhackData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
