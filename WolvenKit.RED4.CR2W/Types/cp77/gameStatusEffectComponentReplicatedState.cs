using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatusEffectComponentReplicatedState : netIComponentState
	{
		private CArray<gameStatusEffectReplicatedInfo> _replicatedInfo;

		[Ordinal(2)] 
		[RED("replicatedInfo")] 
		public CArray<gameStatusEffectReplicatedInfo> ReplicatedInfo
		{
			get
			{
				if (_replicatedInfo == null)
				{
					_replicatedInfo = (CArray<gameStatusEffectReplicatedInfo>) CR2WTypeManager.Create("array:gameStatusEffectReplicatedInfo", "replicatedInfo", cr2w, this);
				}
				return _replicatedInfo;
			}
			set
			{
				if (_replicatedInfo == value)
				{
					return;
				}
				_replicatedInfo = value;
				PropertySet(this);
			}
		}

		public gameStatusEffectComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
