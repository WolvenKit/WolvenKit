using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCensorshipController : inkWidgetLogicController
	{
		private CEnum<CensorshipFlags> _censorshipFlags;

		[Ordinal(1)] 
		[RED("censorshipFlags")] 
		public CEnum<CensorshipFlags> CensorshipFlags
		{
			get => GetProperty(ref _censorshipFlags);
			set => SetProperty(ref _censorshipFlags, value);
		}

		public inkCensorshipController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
