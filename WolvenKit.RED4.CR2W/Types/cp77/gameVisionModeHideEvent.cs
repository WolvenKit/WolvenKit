using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeHideEvent : redEvent
	{
		private CBool _hide;
		private CEnum<gameVisionModeType> _type;

		[Ordinal(0)] 
		[RED("hide")] 
		public CBool Hide
		{
			get => GetProperty(ref _hide);
			set => SetProperty(ref _hide, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gameVisionModeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public gameVisionModeHideEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
