using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLanePlayerGPSInfo : CVariable
	{
		private CUInt16 _subGraphId;
		private CUInt16 _stronglyConnectedComponentId;

		[Ordinal(0)] 
		[RED("subGraphId")] 
		public CUInt16 SubGraphId
		{
			get
			{
				if (_subGraphId == null)
				{
					_subGraphId = (CUInt16) CR2WTypeManager.Create("Uint16", "subGraphId", cr2w, this);
				}
				return _subGraphId;
			}
			set
			{
				if (_subGraphId == value)
				{
					return;
				}
				_subGraphId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("stronglyConnectedComponentId")] 
		public CUInt16 StronglyConnectedComponentId
		{
			get
			{
				if (_stronglyConnectedComponentId == null)
				{
					_stronglyConnectedComponentId = (CUInt16) CR2WTypeManager.Create("Uint16", "stronglyConnectedComponentId", cr2w, this);
				}
				return _stronglyConnectedComponentId;
			}
			set
			{
				if (_stronglyConnectedComponentId == value)
				{
					return;
				}
				_stronglyConnectedComponentId = value;
				PropertySet(this);
			}
		}

		public worldTrafficLanePlayerGPSInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
