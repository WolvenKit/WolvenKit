using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeakspotOnDestroyEvent : redEvent
	{
		private WeakspotRecordData _weakspotRecordData;

		[Ordinal(0)] 
		[RED("weakspotRecordData")] 
		public WeakspotRecordData WeakspotRecordData
		{
			get
			{
				if (_weakspotRecordData == null)
				{
					_weakspotRecordData = (WeakspotRecordData) CR2WTypeManager.Create("WeakspotRecordData", "weakspotRecordData", cr2w, this);
				}
				return _weakspotRecordData;
			}
			set
			{
				if (_weakspotRecordData == value)
				{
					return;
				}
				_weakspotRecordData = value;
				PropertySet(this);
			}
		}

		public WeakspotOnDestroyEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
