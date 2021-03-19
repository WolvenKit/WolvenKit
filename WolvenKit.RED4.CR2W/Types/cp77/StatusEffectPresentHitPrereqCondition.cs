using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatusEffectPresentHitPrereqCondition : BaseHitPrereqCondition
	{
		private CName _checkType;
		private CName _statusEffectParam;
		private CName _tag;
		private CName _objectToCheck;

		[Ordinal(1)] 
		[RED("checkType")] 
		public CName CheckType
		{
			get => GetProperty(ref _checkType);
			set => SetProperty(ref _checkType, value);
		}

		[Ordinal(2)] 
		[RED("statusEffectParam")] 
		public CName StatusEffectParam
		{
			get => GetProperty(ref _statusEffectParam);
			set => SetProperty(ref _statusEffectParam, value);
		}

		[Ordinal(3)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(4)] 
		[RED("objectToCheck")] 
		public CName ObjectToCheck
		{
			get => GetProperty(ref _objectToCheck);
			set => SetProperty(ref _objectToCheck, value);
		}

		public StatusEffectPresentHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
