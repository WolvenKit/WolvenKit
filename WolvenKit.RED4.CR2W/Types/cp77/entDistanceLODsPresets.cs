using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entDistanceLODsPresets : ISerializable
	{
		private CStatic<entLODDefinition> _definitions;

		[Ordinal(0)] 
		[RED("definitions", 4)] 
		public CStatic<entLODDefinition> Definitions
		{
			get => GetProperty(ref _definitions);
			set => SetProperty(ref _definitions, value);
		}

		public entDistanceLODsPresets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
