using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitRepresentationOverride : ISerializable
	{
		private gameHitShapeContainer _represenationOverride;

		[Ordinal(0)] 
		[RED("represenationOverride")] 
		public gameHitShapeContainer RepresenationOverride
		{
			get => GetProperty(ref _represenationOverride);
			set => SetProperty(ref _represenationOverride, value);
		}

		public gameHitRepresentationOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
