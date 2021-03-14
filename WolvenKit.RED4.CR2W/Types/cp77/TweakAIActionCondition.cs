using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TweakAIActionCondition : TweakAIActionConditionAbstract
	{
		private TweakDBID _record;

		[Ordinal(2)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get
			{
				if (_record == null)
				{
					_record = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "record", cr2w, this);
				}
				return _record;
			}
			set
			{
				if (_record == value)
				{
					return;
				}
				_record = value;
				PropertySet(this);
			}
		}

		public TweakAIActionCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
