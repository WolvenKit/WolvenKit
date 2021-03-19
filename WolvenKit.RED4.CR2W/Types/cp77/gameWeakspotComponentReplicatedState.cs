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
			get => GetProperty(ref _weakspotRepInfos);
			set => SetProperty(ref _weakspotRepInfos, value);
		}

		public gameWeakspotComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
