using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AppearanceRandomizerComponent : gameScriptableComponent
	{
		private CArray<CName> _appearances;
		private CBool _isEnabled;

		[Ordinal(5)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get => GetProperty(ref _appearances);
			set => SetProperty(ref _appearances, value);
		}

		[Ordinal(6)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		public AppearanceRandomizerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
