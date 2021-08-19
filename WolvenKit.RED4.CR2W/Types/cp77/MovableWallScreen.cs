using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MovableWallScreen : Door
	{
		private CFloat _animationLength;
		private CHandle<AnimFeature_SimpleDevice> _animFeature;

		[Ordinal(140)] 
		[RED("animationLength")] 
		public CFloat AnimationLength
		{
			get => GetProperty(ref _animationLength);
			set => SetProperty(ref _animationLength, value);
		}

		[Ordinal(141)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SimpleDevice> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		public MovableWallScreen(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
