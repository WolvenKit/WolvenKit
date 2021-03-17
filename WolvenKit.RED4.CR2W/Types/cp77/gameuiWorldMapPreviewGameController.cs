using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapPreviewGameController : gameuiMenuGameController
	{
		private raRef<entEntityTemplate> _viewTemplate;
		private rRef<worldEnvironmentAreaParameters> _viewEnvironmentDefinition;
		private raRef<entEntityTemplate> _cursorTemplate;

		[Ordinal(3)] 
		[RED("viewTemplate")] 
		public raRef<entEntityTemplate> ViewTemplate
		{
			get => GetProperty(ref _viewTemplate);
			set => SetProperty(ref _viewTemplate, value);
		}

		[Ordinal(4)] 
		[RED("viewEnvironmentDefinition")] 
		public rRef<worldEnvironmentAreaParameters> ViewEnvironmentDefinition
		{
			get => GetProperty(ref _viewEnvironmentDefinition);
			set => SetProperty(ref _viewEnvironmentDefinition, value);
		}

		[Ordinal(5)] 
		[RED("cursorTemplate")] 
		public raRef<entEntityTemplate> CursorTemplate
		{
			get => GetProperty(ref _cursorTemplate);
			set => SetProperty(ref _cursorTemplate, value);
		}

		public gameuiWorldMapPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
