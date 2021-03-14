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
			get
			{
				if (_roleCbId == null)
				{
					_roleCbId = (CUInt32) CR2WTypeManager.Create("Uint32", "roleCbId", cr2w, this);
				}
				return _roleCbId;
			}
			set
			{
				if (_roleCbId == value)
				{
					return;
				}
				_roleCbId = value;
				PropertySet(this);
			}
		}

		public PassiveIsPlayerCompanionCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
