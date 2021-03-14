using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DrillerScanEvent : redEvent
	{
		private CBool _newIsScanning;

		[Ordinal(0)] 
		[RED("newIsScanning")] 
		public CBool NewIsScanning
		{
			get
			{
				if (_newIsScanning == null)
				{
					_newIsScanning = (CBool) CR2WTypeManager.Create("Bool", "newIsScanning", cr2w, this);
				}
				return _newIsScanning;
			}
			set
			{
				if (_newIsScanning == value)
				{
					return;
				}
				_newIsScanning = value;
				PropertySet(this);
			}
		}

		public DrillerScanEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
