using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		private CName _targetType;

		[Ordinal(1)] 
		[RED("targetType")] 
		public CName TargetType
		{
			get => GetProperty(ref _targetType);
			set => SetProperty(ref _targetType, value);
		}

		public TargetTypeHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
