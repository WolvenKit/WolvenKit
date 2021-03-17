using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLayerDefinition : CVariable
	{
		private CBool _enabled;
		private rRef<inkWidgetLibraryResource> _rootLibrary;
		private CBool _activeByDefault;
		private CBool _isPermanent;
		private CBool _useGlobalStyleTheme;
		private CBool _isAffectedByFadeout;
		private CBool _useGameInput;
		private CName _inputContext;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(1)] 
		[RED("rootLibrary")] 
		public rRef<inkWidgetLibraryResource> RootLibrary
		{
			get => GetProperty(ref _rootLibrary);
			set => SetProperty(ref _rootLibrary, value);
		}

		[Ordinal(2)] 
		[RED("activeByDefault")] 
		public CBool ActiveByDefault
		{
			get => GetProperty(ref _activeByDefault);
			set => SetProperty(ref _activeByDefault, value);
		}

		[Ordinal(3)] 
		[RED("isPermanent")] 
		public CBool IsPermanent
		{
			get => GetProperty(ref _isPermanent);
			set => SetProperty(ref _isPermanent, value);
		}

		[Ordinal(4)] 
		[RED("useGlobalStyleTheme")] 
		public CBool UseGlobalStyleTheme
		{
			get => GetProperty(ref _useGlobalStyleTheme);
			set => SetProperty(ref _useGlobalStyleTheme, value);
		}

		[Ordinal(5)] 
		[RED("isAffectedByFadeout")] 
		public CBool IsAffectedByFadeout
		{
			get => GetProperty(ref _isAffectedByFadeout);
			set => SetProperty(ref _isAffectedByFadeout, value);
		}

		[Ordinal(6)] 
		[RED("useGameInput")] 
		public CBool UseGameInput
		{
			get => GetProperty(ref _useGameInput);
			set => SetProperty(ref _useGameInput, value);
		}

		[Ordinal(7)] 
		[RED("inputContext")] 
		public CName InputContext
		{
			get => GetProperty(ref _inputContext);
			set => SetProperty(ref _inputContext, value);
		}

		public inkLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
