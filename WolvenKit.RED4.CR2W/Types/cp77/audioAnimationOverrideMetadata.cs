using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAnimationOverrideMetadata : audioAudioMetadata
	{
		private CHandle<audioAnimationOverrideDictionary> _animationOverrides;

		[Ordinal(1)] 
		[RED("animationOverrides")] 
		public CHandle<audioAnimationOverrideDictionary> AnimationOverrides
		{
			get => GetProperty(ref _animationOverrides);
			set => SetProperty(ref _animationOverrides, value);
		}

		public audioAnimationOverrideMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
