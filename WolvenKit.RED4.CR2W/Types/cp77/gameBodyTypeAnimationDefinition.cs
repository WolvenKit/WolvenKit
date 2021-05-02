using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBodyTypeAnimationDefinition : CVariable
	{
		private raRef<animRig> _rig;
		private CArray<raRef<animAnimSet>> _animsets;
		private CArray<gameAnimationOverrideDefinition> _overrides;

		[Ordinal(0)] 
		[RED("rig")] 
		public raRef<animRig> Rig
		{
			get => GetProperty(ref _rig);
			set => SetProperty(ref _rig, value);
		}

		[Ordinal(1)] 
		[RED("animsets")] 
		public CArray<raRef<animAnimSet>> Animsets
		{
			get => GetProperty(ref _animsets);
			set => SetProperty(ref _animsets, value);
		}

		[Ordinal(2)] 
		[RED("overrides")] 
		public CArray<gameAnimationOverrideDefinition> Overrides
		{
			get => GetProperty(ref _overrides);
			set => SetProperty(ref _overrides, value);
		}

		public gameBodyTypeAnimationDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
