using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadialPointerController : inkWidgetLogicController
	{
		private inkImageWidgetReference _pointer;
		private inkImageWidgetReference _feedback;

		[Ordinal(1)] 
		[RED("pointer")] 
		public inkImageWidgetReference Pointer
		{
			get => GetProperty(ref _pointer);
			set => SetProperty(ref _pointer, value);
		}

		[Ordinal(2)] 
		[RED("feedback")] 
		public inkImageWidgetReference Feedback
		{
			get => GetProperty(ref _feedback);
			set => SetProperty(ref _feedback, value);
		}

		public RadialPointerController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
