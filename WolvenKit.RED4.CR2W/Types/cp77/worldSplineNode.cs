using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldSplineNode : worldSocketNode
	{
		private CHandle<Spline> _splineData;
		private NodeRef _destSnapedNode;
		private CName _destSnapedSocketName;
		private NodeRef _entrySnapedNode;
		private CName _entrySnapedSocketName;

		[Ordinal(4)] 
		[RED("splineData")] 
		public CHandle<Spline> SplineData
		{
			get => GetProperty(ref _splineData);
			set => SetProperty(ref _splineData, value);
		}

		[Ordinal(5)] 
		[RED("destSnapedNode")] 
		public NodeRef DestSnapedNode
		{
			get => GetProperty(ref _destSnapedNode);
			set => SetProperty(ref _destSnapedNode, value);
		}

		[Ordinal(6)] 
		[RED("destSnapedSocketName")] 
		public CName DestSnapedSocketName
		{
			get => GetProperty(ref _destSnapedSocketName);
			set => SetProperty(ref _destSnapedSocketName, value);
		}

		[Ordinal(7)] 
		[RED("entrySnapedNode")] 
		public NodeRef EntrySnapedNode
		{
			get => GetProperty(ref _entrySnapedNode);
			set => SetProperty(ref _entrySnapedNode, value);
		}

		[Ordinal(8)] 
		[RED("entrySnapedSocketName")] 
		public CName EntrySnapedSocketName
		{
			get => GetProperty(ref _entrySnapedSocketName);
			set => SetProperty(ref _entrySnapedSocketName, value);
		}

		public worldSplineNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
