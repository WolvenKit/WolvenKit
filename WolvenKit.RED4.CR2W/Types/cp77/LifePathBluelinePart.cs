using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LifePathBluelinePart : gameinteractionsvisBluelinePart
	{
		private CHandle<gamedataLifePath_Record> _record;

		[Ordinal(2)] 
		[RED("record")] 
		public CHandle<gamedataLifePath_Record> Record
		{
			get
			{
				if (_record == null)
				{
					_record = (CHandle<gamedataLifePath_Record>) CR2WTypeManager.Create("handle:gamedataLifePath_Record", "record", cr2w, this);
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

		public LifePathBluelinePart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
