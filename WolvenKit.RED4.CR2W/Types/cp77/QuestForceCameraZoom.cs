using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestForceCameraZoom : ActionBool
	{
		private CBool _useWorkspot;

		[Ordinal(25)] 
		[RED("useWorkspot")] 
		public CBool UseWorkspot
		{
			get => GetProperty(ref _useWorkspot);
			set => SetProperty(ref _useWorkspot, value);
		}

		public QuestForceCameraZoom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
