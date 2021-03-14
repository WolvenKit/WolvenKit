using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BraindanceInputChangeEvent : redEvent
	{
		private CHandle<BraindanceSystem> _bdSystem;

		[Ordinal(0)] 
		[RED("bdSystem")] 
		public CHandle<BraindanceSystem> BdSystem
		{
			get
			{
				if (_bdSystem == null)
				{
					_bdSystem = (CHandle<BraindanceSystem>) CR2WTypeManager.Create("handle:BraindanceSystem", "bdSystem", cr2w, this);
				}
				return _bdSystem;
			}
			set
			{
				if (_bdSystem == value)
				{
					return;
				}
				_bdSystem = value;
				PropertySet(this);
			}
		}

		public BraindanceInputChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
