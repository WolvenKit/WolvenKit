using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeEvent : redEvent
	{
		private CBool _activated;
		private CEnum<gameVisionModeType> _type;

		[Ordinal(0)] 
		[RED("activated")] 
		public CBool Activated
		{
			get => GetProperty(ref _activated);
			set => SetProperty(ref _activated, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gameVisionModeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public gameVisionModeEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
