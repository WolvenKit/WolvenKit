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
			get => GetProperty(ref _weakspotRecordData);
			set => SetProperty(ref _weakspotRecordData, value);
		}

		public WeakspotOnDestroyEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
