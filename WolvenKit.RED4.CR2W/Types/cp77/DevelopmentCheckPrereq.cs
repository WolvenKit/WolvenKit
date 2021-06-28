using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DevelopmentCheckPrereq : gameIScriptablePrereq
	{
		private CFloat _requiredLevel;

		[Ordinal(0)] 
		[RED("requiredLevel")] 
		public CFloat RequiredLevel
		{
			get => GetProperty(ref _requiredLevel);
			set => SetProperty(ref _requiredLevel, value);
		}

		public DevelopmentCheckPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
