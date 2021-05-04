using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehiclePortalsList : IScriptable
	{
		private CArray<NodeRef> _listPoints;

		[Ordinal(0)] 
		[RED("listPoints")] 
		public CArray<NodeRef> ListPoints
		{
			get => GetProperty(ref _listPoints);
			set => SetProperty(ref _listPoints, value);
		}

		public vehiclePortalsList(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
