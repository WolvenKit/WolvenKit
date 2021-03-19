using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WoundedInstigated : redEvent
	{
		private CEnum<EHitReactionZone> _bodyPart;

		[Ordinal(0)] 
		[RED("bodyPart")] 
		public CEnum<EHitReactionZone> BodyPart
		{
			get => GetProperty(ref _bodyPart);
			set => SetProperty(ref _bodyPart, value);
		}

		public WoundedInstigated(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
