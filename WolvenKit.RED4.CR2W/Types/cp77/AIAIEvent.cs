using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIAIEvent : redEvent
	{
		private CName _name;
		private CFloat _timeToLive;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("timeToLive")] 
		public CFloat TimeToLive
		{
			get => GetProperty(ref _timeToLive);
			set => SetProperty(ref _timeToLive, value);
		}

		public AIAIEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
