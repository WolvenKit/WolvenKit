using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckCurrentWoundedState : AIStatusEffectCondition
	{
		private CEnum<EWoundedBodyPart> _woundedTypeToCompare;

		[Ordinal(0)] 
		[RED("woundedTypeToCompare")] 
		public CEnum<EWoundedBodyPart> WoundedTypeToCompare
		{
			get
			{
				if (_woundedTypeToCompare == null)
				{
					_woundedTypeToCompare = (CEnum<EWoundedBodyPart>) CR2WTypeManager.Create("EWoundedBodyPart", "woundedTypeToCompare", cr2w, this);
				}
				return _woundedTypeToCompare;
			}
			set
			{
				if (_woundedTypeToCompare == value)
				{
					return;
				}
				_woundedTypeToCompare = value;
				PropertySet(this);
			}
		}

		public CheckCurrentWoundedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
