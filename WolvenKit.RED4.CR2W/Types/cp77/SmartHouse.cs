using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SmartHouse : InteractiveMasterDevice
	{
		private CBool _timetableActive;

		[Ordinal(93)] 
		[RED("timetableActive")] 
		public CBool TimetableActive
		{
			get => GetProperty(ref _timetableActive);
			set => SetProperty(ref _timetableActive, value);
		}

		public SmartHouse(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
