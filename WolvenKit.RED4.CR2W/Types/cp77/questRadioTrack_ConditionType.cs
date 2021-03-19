using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRadioTrack_ConditionType : questISystemConditionType
	{
		private CName _radioTrack;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("radioTrack")] 
		public CName RadioTrack
		{
			get => GetProperty(ref _radioTrack);
			set => SetProperty(ref _radioTrack, value);
		}

		[Ordinal(1)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}

		public questRadioTrack_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
