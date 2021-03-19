using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassiveIsPlayerCompanionCondition : PassiveAutonomousCondition
	{
		private CUInt32 _roleCbId;

		[Ordinal(0)] 
		[RED("roleCbId")] 
		public CUInt32 RoleCbId
		{
			get => GetProperty(ref _roleCbId);
			set => SetProperty(ref _roleCbId, value);
		}

		public PassiveIsPlayerCompanionCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
