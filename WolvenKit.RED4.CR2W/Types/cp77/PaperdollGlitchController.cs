using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PaperdollGlitchController : inkWidgetLogicController
	{
		private inkWidgetReference _paperdollGlichRoot;
		private CName _glitchAnimationName;

		[Ordinal(1)] 
		[RED("PaperdollGlichRoot")] 
		public inkWidgetReference PaperdollGlichRoot
		{
			get => GetProperty(ref _paperdollGlichRoot);
			set => SetProperty(ref _paperdollGlichRoot, value);
		}

		[Ordinal(2)] 
		[RED("GlitchAnimationName")] 
		public CName GlitchAnimationName
		{
			get => GetProperty(ref _glitchAnimationName);
			set => SetProperty(ref _glitchAnimationName, value);
		}

		public PaperdollGlitchController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
