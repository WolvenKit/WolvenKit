using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatCheckPrereq : DevelopmentCheckPrereq
	{
		private CEnum<gamedataStatType> _statToCheck;

		[Ordinal(1)] 
		[RED("statToCheck")] 
		public CEnum<gamedataStatType> StatToCheck
		{
			get
			{
				if (_statToCheck == null)
				{
					_statToCheck = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "statToCheck", cr2w, this);
				}
				return _statToCheck;
			}
			set
			{
				if (_statToCheck == value)
				{
					return;
				}
				_statToCheck = value;
				PropertySet(this);
			}
		}

		public StatCheckPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
