using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericHitPrereq : gameIScriptablePrereq
	{
		private CBool _isSync;
		private CEnum<gameDamageCallbackType> _callbackType;
		private CEnum<gameDamagePipelineStage> _pipelineStage;
		private CEnum<gamedataAttackType> _attackType;
		private CArray<CHandle<BaseHitPrereqCondition>> _conditions;

		[Ordinal(0)] 
		[RED("isSync")] 
		public CBool IsSync
		{
			get => GetProperty(ref _isSync);
			set => SetProperty(ref _isSync, value);
		}

		[Ordinal(1)] 
		[RED("callbackType")] 
		public CEnum<gameDamageCallbackType> CallbackType
		{
			get => GetProperty(ref _callbackType);
			set => SetProperty(ref _callbackType, value);
		}

		[Ordinal(2)] 
		[RED("pipelineStage")] 
		public CEnum<gameDamagePipelineStage> PipelineStage
		{
			get => GetProperty(ref _pipelineStage);
			set => SetProperty(ref _pipelineStage, value);
		}

		[Ordinal(3)] 
		[RED("attackType")] 
		public CEnum<gamedataAttackType> AttackType
		{
			get => GetProperty(ref _attackType);
			set => SetProperty(ref _attackType, value);
		}

		[Ordinal(4)] 
		[RED("conditions")] 
		public CArray<CHandle<BaseHitPrereqCondition>> Conditions
		{
			get => GetProperty(ref _conditions);
			set => SetProperty(ref _conditions, value);
		}

		public GenericHitPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
