using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ComputerSetup : TerminalSetup
	{
		[Ordinal(0)]  [RED("animationState")] public CEnum<EComputerAnimationState> AnimationState { get; set; }
		[Ordinal(1)]  [RED("filesMenu")] public CBool FilesMenu { get; set; }
		[Ordinal(2)]  [RED("filesStructure")] public CArray<gamedeviceGenericDataContent> FilesStructure { get; set; }
		[Ordinal(3)]  [RED("internetMenu")] public CBool InternetMenu { get; set; }
		[Ordinal(4)]  [RED("internetSubnet")] public SInternetData InternetSubnet { get; set; }
		[Ordinal(5)]  [RED("mailsMenu")] public CBool MailsMenu { get; set; }
		[Ordinal(6)]  [RED("mailsStructure")] public CArray<gamedeviceGenericDataContent> MailsStructure { get; set; }
		[Ordinal(7)]  [RED("newsFeed")] public CArray<SNewsFeedElementData> NewsFeed { get; set; }
		[Ordinal(8)]  [RED("newsFeedInterval")] public CFloat NewsFeedInterval { get; set; }
		[Ordinal(9)]  [RED("newsFeedMenu")] public CBool NewsFeedMenu { get; set; }
		[Ordinal(10)]  [RED("startingMenu")] public CEnum<EComputerMenuType> StartingMenu { get; set; }
		[Ordinal(11)]  [RED("systemMenu")] public CBool SystemMenu { get; set; }

		public ComputerSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
