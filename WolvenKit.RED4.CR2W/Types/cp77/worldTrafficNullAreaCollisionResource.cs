using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficNullAreaCollisionResource : CResource
	{
		private CHandle<worldTrafficNullAreaCollisionData> _nullAreasCollisionData;
		private CHandle<worldTrafficNullAreaDynamicBlockadeData> _nullAreaBlockadeData;

		[Ordinal(1)] 
		[RED("nullAreasCollisionData")] 
		public CHandle<worldTrafficNullAreaCollisionData> NullAreasCollisionData
		{
			get
			{
				if (_nullAreasCollisionData == null)
				{
					_nullAreasCollisionData = (CHandle<worldTrafficNullAreaCollisionData>) CR2WTypeManager.Create("handle:worldTrafficNullAreaCollisionData", "nullAreasCollisionData", cr2w, this);
				}
				return _nullAreasCollisionData;
			}
			set
			{
				if (_nullAreasCollisionData == value)
				{
					return;
				}
				_nullAreasCollisionData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("nullAreaBlockadeData")] 
		public CHandle<worldTrafficNullAreaDynamicBlockadeData> NullAreaBlockadeData
		{
			get
			{
				if (_nullAreaBlockadeData == null)
				{
					_nullAreaBlockadeData = (CHandle<worldTrafficNullAreaDynamicBlockadeData>) CR2WTypeManager.Create("handle:worldTrafficNullAreaDynamicBlockadeData", "nullAreaBlockadeData", cr2w, this);
				}
				return _nullAreaBlockadeData;
			}
			set
			{
				if (_nullAreaBlockadeData == value)
				{
					return;
				}
				_nullAreaBlockadeData = value;
				PropertySet(this);
			}
		}

		public worldTrafficNullAreaCollisionResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
