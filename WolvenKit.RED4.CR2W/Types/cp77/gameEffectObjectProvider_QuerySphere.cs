using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_QuerySphere : gameEffectObjectProvider
	{
		private CBool _gatherOnlyPuppets;
		private CHandle<physicsFilterData> _filterData;

		[Ordinal(0)] 
		[RED("gatherOnlyPuppets")] 
		public CBool GatherOnlyPuppets
		{
			get
			{
				if (_gatherOnlyPuppets == null)
				{
					_gatherOnlyPuppets = (CBool) CR2WTypeManager.Create("Bool", "gatherOnlyPuppets", cr2w, this);
				}
				return _gatherOnlyPuppets;
			}
			set
			{
				if (_gatherOnlyPuppets == value)
				{
					return;
				}
				_gatherOnlyPuppets = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public gameEffectObjectProvider_QuerySphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
