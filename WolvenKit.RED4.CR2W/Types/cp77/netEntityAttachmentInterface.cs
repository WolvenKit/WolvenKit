using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class netEntityAttachmentInterface : CVariable
	{
		private netTime _time;

		[Ordinal(0)] 
		[RED("time")] 
		public netTime Time
		{
			get
			{
				if (_time == null)
				{
					_time = (netTime) CR2WTypeManager.Create("netTime", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		public netEntityAttachmentInterface(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
