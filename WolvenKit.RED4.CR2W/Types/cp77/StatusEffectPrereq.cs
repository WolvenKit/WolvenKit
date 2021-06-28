using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatusEffectPrereq : gameIScriptablePrereq
	{
		private TweakDBID _statusEffectRecordID;
		private CName _tag;
		private CString _checkType;
		private CBool _invert;
		private CBool _fireAndForget;

		[Ordinal(0)] 
		[RED("statusEffectRecordID")] 
		public TweakDBID StatusEffectRecordID
		{
			get => GetProperty(ref _statusEffectRecordID);
			set => SetProperty(ref _statusEffectRecordID, value);
		}

		[Ordinal(1)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(2)] 
		[RED("checkType")] 
		public CString CheckType
		{
			get => GetProperty(ref _checkType);
			set => SetProperty(ref _checkType, value);
		}

		[Ordinal(3)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}

		[Ordinal(4)] 
		[RED("fireAndForget")] 
		public CBool FireAndForget
		{
			get => GetProperty(ref _fireAndForget);
			set => SetProperty(ref _fireAndForget, value);
		}

		public StatusEffectPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
