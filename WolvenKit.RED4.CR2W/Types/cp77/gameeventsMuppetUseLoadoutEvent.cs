using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsMuppetUseLoadoutEvent : redEvent
	{
		private CHandle<gamedataCPOLoadoutBase_Record> _adout;

		[Ordinal(0)] 
		[RED("adout")] 
		public CHandle<gamedataCPOLoadoutBase_Record> Adout
		{
			get
			{
				if (_adout == null)
				{
					_adout = (CHandle<gamedataCPOLoadoutBase_Record>) CR2WTypeManager.Create("handle:gamedataCPOLoadoutBase_Record", "adout", cr2w, this);
				}
				return _adout;
			}
			set
			{
				if (_adout == value)
				{
					return;
				}
				_adout = value;
				PropertySet(this);
			}
		}

		public gameeventsMuppetUseLoadoutEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
