using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TweakAIAction : TweakAIActionAbstract
	{
		private TweakDBID _record;

		[Ordinal(27)] 
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

		public TweakAIAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
