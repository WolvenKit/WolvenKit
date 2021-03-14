using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HighLevelNPCStatePrereq : NPCStatePrereq
	{
		private CEnum<gamedataNPCHighLevelState> _valueToListen;

		[Ordinal(3)] 
		[RED("valueToListen")] 
		public CEnum<gamedataNPCHighLevelState> ValueToListen
		{
			get
			{
				if (_valueToListen == null)
				{
					_valueToListen = (CEnum<gamedataNPCHighLevelState>) CR2WTypeManager.Create("gamedataNPCHighLevelState", "valueToListen", cr2w, this);
				}
				return _valueToListen;
			}
			set
			{
				if (_valueToListen == value)
				{
					return;
				}
				_valueToListen = value;
				PropertySet(this);
			}
		}

		public HighLevelNPCStatePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
