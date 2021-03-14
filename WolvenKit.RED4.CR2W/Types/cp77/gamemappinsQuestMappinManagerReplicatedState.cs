using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsQuestMappinManagerReplicatedState : CVariable
	{
		private CArray<gamemappinsDynamicQuestMappinRepInfo> _dynamicQuestMappinRepInfo;

		[Ordinal(0)] 
		[RED("dynamicQuestMappinRepInfo")] 
		public CArray<gamemappinsDynamicQuestMappinRepInfo> DynamicQuestMappinRepInfo
		{
			get
			{
				if (_dynamicQuestMappinRepInfo == null)
				{
					_dynamicQuestMappinRepInfo = (CArray<gamemappinsDynamicQuestMappinRepInfo>) CR2WTypeManager.Create("array:gamemappinsDynamicQuestMappinRepInfo", "dynamicQuestMappinRepInfo", cr2w, this);
				}
				return _dynamicQuestMappinRepInfo;
			}
			set
			{
				if (_dynamicQuestMappinRepInfo == value)
				{
					return;
				}
				_dynamicQuestMappinRepInfo = value;
				PropertySet(this);
			}
		}

		public gamemappinsQuestMappinManagerReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
