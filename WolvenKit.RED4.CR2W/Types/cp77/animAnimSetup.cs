using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimSetup : CVariable
	{
		private CArray<animAnimSetupEntry> _cinematics;
		private CArray<animAnimSetupEntry> _gameplay;

		[Ordinal(0)] 
		[RED("cinematics")] 
		public CArray<animAnimSetupEntry> Cinematics
		{
			get => GetProperty(ref _cinematics);
			set => SetProperty(ref _cinematics, value);
		}

		[Ordinal(1)] 
		[RED("gameplay")] 
		public CArray<animAnimSetupEntry> Gameplay
		{
			get => GetProperty(ref _gameplay);
			set => SetProperty(ref _gameplay, value);
		}

		public animAnimSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
