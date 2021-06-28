using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeadOnInitTask : AIbehaviortaskScript
	{
		private CBool _preventSkippingDeathAnimation;

		[Ordinal(0)] 
		[RED("preventSkippingDeathAnimation")] 
		public CBool PreventSkippingDeathAnimation
		{
			get => GetProperty(ref _preventSkippingDeathAnimation);
			set => SetProperty(ref _preventSkippingDeathAnimation, value);
		}

		public DeadOnInitTask(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
