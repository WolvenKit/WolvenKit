using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MediaDeviceData : CVariable
	{
		[Ordinal(0)]  [RED("activeChannelName")] public CString ActiveChannelName { get; set; }
		[Ordinal(1)]  [RED("amountOfStations")] public CInt32 AmountOfStations { get; set; }
		[Ordinal(2)]  [RED("initialStation")] public CInt32 InitialStation { get; set; }
		[Ordinal(3)]  [RED("isInteractive")] public CBool IsInteractive { get; set; }

		public MediaDeviceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
