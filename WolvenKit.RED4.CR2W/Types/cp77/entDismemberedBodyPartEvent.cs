using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entDismemberedBodyPartEvent : redEvent
	{
		private CStatic<CName> _bones;

		[Ordinal(0)] 
		[RED("bones", 32)] 
		public CStatic<CName> Bones
		{
			get => GetProperty(ref _bones);
			set => SetProperty(ref _bones, value);
		}

		public entDismemberedBodyPartEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
