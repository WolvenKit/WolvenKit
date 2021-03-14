using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCompiledCommunityAreaNode : worldNode
	{
		private CHandle<communityArea> _area;
		private entEntityID _sourceObjectId;

		[Ordinal(4)] 
		[RED("area")] 
		public CHandle<communityArea> Area
		{
			get
			{
				if (_area == null)
				{
					_area = (CHandle<communityArea>) CR2WTypeManager.Create("handle:communityArea", "area", cr2w, this);
				}
				return _area;
			}
			set
			{
				if (_area == value)
				{
					return;
				}
				_area = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("sourceObjectId")] 
		public entEntityID SourceObjectId
		{
			get
			{
				if (_sourceObjectId == null)
				{
					_sourceObjectId = (entEntityID) CR2WTypeManager.Create("entEntityID", "sourceObjectId", cr2w, this);
				}
				return _sourceObjectId;
			}
			set
			{
				if (_sourceObjectId == value)
				{
					return;
				}
				_sourceObjectId = value;
				PropertySet(this);
			}
		}

		public worldCompiledCommunityAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
