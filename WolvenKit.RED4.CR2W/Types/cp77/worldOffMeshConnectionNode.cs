using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldOffMeshConnectionNode : worldSplineNode
	{
		private CBool _isBidirectional;
		private CFloat _radius;
		private CEnum<worldOffMeshConnectionType> _type;
		private CArray<CName> _tags;

		[Ordinal(9)] 
		[RED("isBidirectional")] 
		public CBool IsBidirectional
		{
			get => GetProperty(ref _isBidirectional);
			set => SetProperty(ref _isBidirectional, value);
		}

		[Ordinal(10)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(11)] 
		[RED("type")] 
		public CEnum<worldOffMeshConnectionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(12)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		public worldOffMeshConnectionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
