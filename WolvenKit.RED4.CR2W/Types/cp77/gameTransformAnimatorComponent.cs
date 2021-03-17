using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimatorComponent : entIPlacedComponent
	{
		private CArray<gameTransformAnimationDefinition> _animations;

		[Ordinal(5)] 
		[RED("animations")] 
		public CArray<gameTransformAnimationDefinition> Animations
		{
			get => GetProperty(ref _animations);
			set => SetProperty(ref _animations, value);
		}

		public gameTransformAnimatorComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
