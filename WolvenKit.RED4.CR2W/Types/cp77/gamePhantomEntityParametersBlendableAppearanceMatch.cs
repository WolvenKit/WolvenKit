using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePhantomEntityParametersBlendableAppearanceMatch : CVariable
	{
		private CName _blendable;
		private CName _notBlendable;

		[Ordinal(0)] 
		[RED("blendable")] 
		public CName Blendable
		{
			get => GetProperty(ref _blendable);
			set => SetProperty(ref _blendable, value);
		}

		[Ordinal(1)] 
		[RED("notBlendable")] 
		public CName NotBlendable
		{
			get => GetProperty(ref _notBlendable);
			set => SetProperty(ref _notBlendable, value);
		}

		public gamePhantomEntityParametersBlendableAppearanceMatch(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
