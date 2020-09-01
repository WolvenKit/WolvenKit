using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CSwarmCellMap : CResource
	{
		[Ordinal(0)] [RED("cellSize")] 		public CFloat CellSize { get; set;}

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSwarmCellMap(cr2w, parent, name);

	}
}