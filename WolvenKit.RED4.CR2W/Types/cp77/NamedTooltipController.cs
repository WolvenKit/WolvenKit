using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NamedTooltipController : IScriptable
	{
		private CName _identifier;
		private wCHandle<AGenericTooltipController> _controller;

		[Ordinal(0)] 
		[RED("identifier")] 
		public CName Identifier
		{
			get => GetProperty(ref _identifier);
			set => SetProperty(ref _identifier, value);
		}

		[Ordinal(1)] 
		[RED("controller")] 
		public wCHandle<AGenericTooltipController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		public NamedTooltipController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
