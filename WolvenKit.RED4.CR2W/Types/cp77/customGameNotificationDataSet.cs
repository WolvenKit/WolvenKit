using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class customGameNotificationDataSet : inkGameNotificationData
	{
		private CName _customText;
		private CBool _testBool;

		[Ordinal(6)] 
		[RED("customText")] 
		public CName CustomText
		{
			get => GetProperty(ref _customText);
			set => SetProperty(ref _customText, value);
		}

		[Ordinal(7)] 
		[RED("testBool")] 
		public CBool TestBool
		{
			get => GetProperty(ref _testBool);
			set => SetProperty(ref _testBool, value);
		}

		public customGameNotificationDataSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
