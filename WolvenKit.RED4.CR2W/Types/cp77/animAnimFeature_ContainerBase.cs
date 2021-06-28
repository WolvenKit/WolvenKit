using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_ContainerBase : animAnimFeature
	{
		private CBool _opened;
		private CFloat _transitionDuration;

		[Ordinal(0)] 
		[RED("opened")] 
		public CBool Opened
		{
			get => GetProperty(ref _opened);
			set => SetProperty(ref _opened, value);
		}

		[Ordinal(1)] 
		[RED("transitionDuration")] 
		public CFloat TransitionDuration
		{
			get => GetProperty(ref _transitionDuration);
			set => SetProperty(ref _transitionDuration, value);
		}

		public animAnimFeature_ContainerBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
