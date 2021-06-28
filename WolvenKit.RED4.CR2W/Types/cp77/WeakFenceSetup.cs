using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeakFenceSetup : CVariable
	{
		private CBool _hasGenericInteraction;

		[Ordinal(0)] 
		[RED("hasGenericInteraction")] 
		public CBool HasGenericInteraction
		{
			get => GetProperty(ref _hasGenericInteraction);
			set => SetProperty(ref _hasGenericInteraction, value);
		}

		public WeakFenceSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
