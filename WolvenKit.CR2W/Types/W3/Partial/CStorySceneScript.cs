using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CStorySceneScript : CStorySceneControlPart
	{
		[Ordinal(1)] [RED("functionName")] 		public CName FunctionName { get; set;}

		[Ordinal(2)] [RED("links", 2,0)] 		public CArray<CPtr<CStorySceneLinkElement>> Links { get; set;}

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneScript(cr2w, parent, name);

	}
}