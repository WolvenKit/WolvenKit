using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MountAssigendVehicle : AIVehicleTaskAbstract
	{
		private CEnum<AIbehaviorUpdateOutcome> _result;

		[Ordinal(0)] 
		[RED("result")] 
		public CEnum<AIbehaviorUpdateOutcome> Result
		{
			get
			{
				if (_result == null)
				{
					_result = (CEnum<AIbehaviorUpdateOutcome>) CR2WTypeManager.Create("AIbehaviorUpdateOutcome", "result", cr2w, this);
				}
				return _result;
			}
			set
			{
				if (_result == value)
				{
					return;
				}
				_result = value;
				PropertySet(this);
			}
		}

		public MountAssigendVehicle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
