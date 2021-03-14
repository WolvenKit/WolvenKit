using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameWeakspotComponentReplicatedState : netIComponentState
	{
		private CArray<gameWeakSpotReplicatedInfo> _weakspotRepInfos;

		[Ordinal(2)] 
		[RED("WeakspotRepInfos")] 
		public CArray<gameWeakSpotReplicatedInfo> WeakspotRepInfos
		{
			get
			{
				if (_weakspotRepInfos == null)
				{
					_weakspotRepInfos = (CArray<gameWeakSpotReplicatedInfo>) CR2WTypeManager.Create("array:gameWeakSpotReplicatedInfo", "WeakspotRepInfos", cr2w, this);
				}
				return _weakspotRepInfos;
			}
			set
			{
				if (_weakspotRepInfos == value)
				{
					return;
				}
				_weakspotRepInfos = value;
				PropertySet(this);
			}
		}

		public gameWeakspotComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
