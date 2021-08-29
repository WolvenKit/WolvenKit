using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionTargetPrereq : gameIScriptablePrereq
	{
		private CWeakHandle<gamedataAIActionTarget_Record> _targetRecord;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("targetRecord")] 
		public CWeakHandle<gamedataAIActionTarget_Record> TargetRecord
		{
			get => GetProperty(ref _targetRecord);
			set => SetProperty(ref _targetRecord, value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}
	}
}
