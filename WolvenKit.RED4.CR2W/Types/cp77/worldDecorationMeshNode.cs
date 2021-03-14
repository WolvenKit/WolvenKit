using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDecorationMeshNode : worldMeshNode
	{
		private CBool _startAsleep;
		private CEnum<physicsFilterDataSource> _filterDataSource;
		private CHandle<physicsFilterData> _filterData;

		[Ordinal(15)] 
		[RED("startAsleep")] 
		public CBool StartAsleep
		{
			get
			{
				if (_startAsleep == null)
				{
					_startAsleep = (CBool) CR2WTypeManager.Create("Bool", "startAsleep", cr2w, this);
				}
				return _startAsleep;
			}
			set
			{
				if (_startAsleep == value)
				{
					return;
				}
				_startAsleep = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("filterDataSource")] 
		public CEnum<physicsFilterDataSource> FilterDataSource
		{
			get
			{
				if (_filterDataSource == null)
				{
					_filterDataSource = (CEnum<physicsFilterDataSource>) CR2WTypeManager.Create("physicsFilterDataSource", "filterDataSource", cr2w, this);
				}
				return _filterDataSource;
			}
			set
			{
				if (_filterDataSource == value)
				{
					return;
				}
				_filterDataSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get
			{
				if (_filterData == null)
				{
					_filterData = (CHandle<physicsFilterData>) CR2WTypeManager.Create("handle:physicsFilterData", "filterData", cr2w, this);
				}
				return _filterData;
			}
			set
			{
				if (_filterData == value)
				{
					return;
				}
				_filterData = value;
				PropertySet(this);
			}
		}

		public worldDecorationMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
