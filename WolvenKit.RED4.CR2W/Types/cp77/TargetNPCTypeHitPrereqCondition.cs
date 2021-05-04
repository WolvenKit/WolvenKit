using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetNPCTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		private CEnum<gamedataNPCType> _type;

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gamedataNPCType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public TargetNPCTypeHitPrereqCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
