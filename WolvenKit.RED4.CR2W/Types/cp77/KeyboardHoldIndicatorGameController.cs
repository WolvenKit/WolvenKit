using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KeyboardHoldIndicatorGameController : gameuiHoldIndicatorGameController
	{
		private inkImageWidgetReference _progress;

		[Ordinal(6)] 
		[RED("progress")] 
		public inkImageWidgetReference Progress
		{
			get
			{
				if (_progress == null)
				{
					_progress = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "progress", cr2w, this);
				}
				return _progress;
			}
			set
			{
				if (_progress == value)
				{
					return;
				}
				_progress = value;
				PropertySet(this);
			}
		}

		public KeyboardHoldIndicatorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
