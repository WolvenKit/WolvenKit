using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisIVisualizerDefinition : ISerializable
	{
		[Ordinal(0)] [RED("flags")] public CEnum<gameinteractionsvisEVisualizerDefinitionFlags> Flags { get; set; }

		public gameinteractionsvisIVisualizerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
