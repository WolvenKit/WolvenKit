using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SceneSystemCarrying : animAnimFeature
	{
		private CBool _carrying;

		[Ordinal(0)] 
		[RED("carrying")] 
		public CBool Carrying
		{
			get => GetProperty(ref _carrying);
			set => SetProperty(ref _carrying, value);
		}

		public AnimFeature_SceneSystemCarrying(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
