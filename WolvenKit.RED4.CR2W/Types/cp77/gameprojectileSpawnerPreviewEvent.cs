using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSpawnerPreviewEvent : redEvent
	{
		private CBool _previewActive;

		[Ordinal(0)] 
		[RED("previewActive")] 
		public CBool PreviewActive
		{
			get => GetProperty(ref _previewActive);
			set => SetProperty(ref _previewActive, value);
		}

		public gameprojectileSpawnerPreviewEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
