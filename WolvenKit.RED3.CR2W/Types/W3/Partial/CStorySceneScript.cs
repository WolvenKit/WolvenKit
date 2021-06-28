using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CStorySceneScript : CStorySceneControlPart
	{
		[Ordinal(1)] [RED("functionName")] 		public CName FunctionName { get; set;}

		[Ordinal(2)] [RED("links", 2,0)] 		public CArray<CPtr<CStorySceneLinkElement>> Links { get; set;}

	}
}
