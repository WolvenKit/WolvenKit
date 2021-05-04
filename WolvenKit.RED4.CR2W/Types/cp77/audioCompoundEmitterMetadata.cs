using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioCompoundEmitterMetadata : audioEmitterMetadata
	{
		private CArray<CName> _childrenNames;

		[Ordinal(1)] 
		[RED("childrenNames")] 
		public CArray<CName> ChildrenNames
		{
			get => GetProperty(ref _childrenNames);
			set => SetProperty(ref _childrenNames, value);
		}

		public audioCompoundEmitterMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
