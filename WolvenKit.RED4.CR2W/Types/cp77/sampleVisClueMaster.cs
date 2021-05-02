using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleVisClueMaster : gameObject
	{
		private CArray<NodeRef> _dependableEntities;

		[Ordinal(40)] 
		[RED("dependableEntities")] 
		public CArray<NodeRef> DependableEntities
		{
			get => GetProperty(ref _dependableEntities);
			set => SetProperty(ref _dependableEntities, value);
		}

		public sampleVisClueMaster(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
