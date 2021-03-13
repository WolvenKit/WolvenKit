using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerPersistentData : CVariable
	{
		[Ordinal(0)] [RED("mails")] public CArray<gamedeviceGenericDataContent> Mails { get; set; }
		[Ordinal(1)] [RED("files")] public CArray<gamedeviceGenericDataContent> Files { get; set; }
		[Ordinal(2)] [RED("newsFeedElements")] public CArray<SNewsFeedElementData> NewsFeedElements { get; set; }
		[Ordinal(3)] [RED("internetData")] public SInternetData InternetData { get; set; }
		[Ordinal(4)] [RED("initialUIPosition")] public CString InitialUIPosition { get; set; }
		[Ordinal(5)] [RED("openedFileIDX")] public CInt32 OpenedFileIDX { get; set; }
		[Ordinal(6)] [RED("openedFolderIDX")] public CInt32 OpenedFolderIDX { get; set; }

		public ComputerPersistentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
