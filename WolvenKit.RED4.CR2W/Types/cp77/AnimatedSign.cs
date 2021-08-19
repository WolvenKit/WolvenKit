using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimatedSign : InteractiveDevice
	{
		private CHandle<AnimFeature_AnimatedDevice> _animFeature;

		[Ordinal(97)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_AnimatedDevice> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		public AnimatedSign(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
