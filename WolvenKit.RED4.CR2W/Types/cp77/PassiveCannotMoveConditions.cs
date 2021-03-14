using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassiveCannotMoveConditions : PassiveAutonomousCondition
	{
		private CUInt32 _statusEffectRemovedId;

		[Ordinal(0)] 
		[RED("statusEffectRemovedId")] 
		public CUInt32 StatusEffectRemovedId
		{
			get
			{
				if (_statusEffectRemovedId == null)
				{
					_statusEffectRemovedId = (CUInt32) CR2WTypeManager.Create("Uint32", "statusEffectRemovedId", cr2w, this);
				}
				return _statusEffectRemovedId;
			}
			set
			{
				if (_statusEffectRemovedId == value)
				{
					return;
				}
				_statusEffectRemovedId = value;
				PropertySet(this);
			}
		}

		public PassiveCannotMoveConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
