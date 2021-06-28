using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProtectedEntities : MorphData
	{
		private CArray<entEntityID> _protectedEntities;

		[Ordinal(1)] 
		[RED("protectedEntities")] 
		public CArray<entEntityID> ProtectedEntities_
		{
			get => GetProperty(ref _protectedEntities);
			set => SetProperty(ref _protectedEntities, value);
		}

		public ProtectedEntities(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
