using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitStatusEffectPresentPrereq : GenericHitPrereq
	{
		private CString _checkType;
		private CString _statusEffectParam;
		private CName _tag;

		[Ordinal(5)] 
		[RED("checkType")] 
		public CString CheckType
		{
			get => GetProperty(ref _checkType);
			set => SetProperty(ref _checkType, value);
		}

		[Ordinal(6)] 
		[RED("statusEffectParam")] 
		public CString StatusEffectParam
		{
			get => GetProperty(ref _statusEffectParam);
			set => SetProperty(ref _statusEffectParam, value);
		}

		[Ordinal(7)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		public HitStatusEffectPresentPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
