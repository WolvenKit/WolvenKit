using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimationSetup : CVariable
	{
		private animAnimSetCollection _cinematics;
		private animAnimSetCollection _gameplay;
		private animAnimSetCollection _finalAnimSetCollection;

		[Ordinal(0)] 
		[RED("cinematics")] 
		public animAnimSetCollection Cinematics
		{
			get => GetProperty(ref _cinematics);
			set => SetProperty(ref _cinematics, value);
		}

		[Ordinal(1)] 
		[RED("gameplay")] 
		public animAnimSetCollection Gameplay
		{
			get => GetProperty(ref _gameplay);
			set => SetProperty(ref _gameplay, value);
		}

		[Ordinal(2)] 
		[RED("finalAnimSetCollection")] 
		public animAnimSetCollection FinalAnimSetCollection
		{
			get => GetProperty(ref _finalAnimSetCollection);
			set => SetProperty(ref _finalAnimSetCollection, value);
		}

		public animAnimationSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
