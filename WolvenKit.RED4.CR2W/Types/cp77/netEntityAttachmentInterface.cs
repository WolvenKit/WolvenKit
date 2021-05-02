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
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		public netEntityAttachmentInterface(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
