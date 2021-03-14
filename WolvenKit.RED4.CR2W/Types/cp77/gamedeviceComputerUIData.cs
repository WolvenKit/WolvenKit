using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedeviceComputerUIData : CVariable
	{
		[Ordinal(0)] [RED("mails")] public CArray<gamedeviceGenericDataContent> Mails { get; set; }
		[Ordinal(1)] [RED("files")] public CArray<gamedeviceGenericDataContent> Files { get; set; }

		public gamedeviceComputerUIData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
