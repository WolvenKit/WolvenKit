using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DEBUG_RebalanceItemEvent : redEvent
	{
		private CFloat _reqLevel;

		[Ordinal(0)] 
		[RED("reqLevel")] 
		public CFloat ReqLevel
		{
			get => GetProperty(ref _reqLevel);
			set => SetProperty(ref _reqLevel, value);
		}

		public DEBUG_RebalanceItemEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
