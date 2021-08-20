using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionTargetInDistancePrereq : gameIScriptablePrereq
	{
		private wCHandle<gamedataAIActionTarget_Record> _targetRecord;
		private CFloat _distance;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("targetRecord")] 
		public wCHandle<gamedataAIActionTarget_Record> TargetRecord
		{
			get => GetProperty(ref _targetRecord);
			set => SetProperty(ref _targetRecord, value);
		}

		[Ordinal(1)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(2)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}

		public ActionTargetInDistancePrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
