using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PresetTimetableEvent : redEvent
	{
		private CInt32 _arrayPosition;

		[Ordinal(0)] 
		[RED("arrayPosition")] 
		public CInt32 ArrayPosition
		{
			get => GetProperty(ref _arrayPosition);
			set => SetProperty(ref _arrayPosition, value);
		}

		public PresetTimetableEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
