using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BaseResaveData : CVariable
	{
		[Ordinal(0)]  [RED("baseDeviceData")] public BaseDeviceData BaseDeviceData { get; set; }
		[Ordinal(1)]  [RED("tweakDBRecord")] public TweakDBID TweakDBRecord { get; set; }

		public BaseResaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
