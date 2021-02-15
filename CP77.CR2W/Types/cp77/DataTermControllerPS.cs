using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DataTermControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("linkedFastTravelPoint")] public CHandle<gameFastTravelPointData> LinkedFastTravelPoint { get; set; }
		[Ordinal(104)] [RED("triggerType")] public CEnum<EFastTravelTriggerType> TriggerType { get; set; }

		public DataTermControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
