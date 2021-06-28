using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileProjectilePreviewEvent : gameprojectileSpawnerPreviewEvent
	{
		private Transform _visualOffset;

		[Ordinal(1)] 
		[RED("visualOffset")] 
		public Transform VisualOffset
		{
			get => GetProperty(ref _visualOffset);
			set => SetProperty(ref _visualOffset, value);
		}

		public gameprojectileProjectilePreviewEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
