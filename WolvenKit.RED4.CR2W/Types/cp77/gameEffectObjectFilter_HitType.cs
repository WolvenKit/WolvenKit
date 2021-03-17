using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_HitType : gameEffectObjectSingleFilter
	{
		private CEnum<gameEffectObjectFilter_HitTypeAction> _action;
		private CEnum<gameEffectHitDataType> _hitType;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<gameEffectObjectFilter_HitTypeAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("hitType")] 
		public CEnum<gameEffectHitDataType> HitType
		{
			get => GetProperty(ref _hitType);
			set => SetProperty(ref _hitType, value);
		}

		public gameEffectObjectFilter_HitType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
