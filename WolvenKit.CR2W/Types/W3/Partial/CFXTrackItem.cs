using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CFXTrackItem : CFXBase
	{
		[RED("timeBegin")] 		public CFloat TimeBegin { get; set;}

		[RED("timeDuration")] 		public CFloat TimeDuration { get; set;}

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFXTrackItem(cr2w, parent, name);

	}
}