using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTierSaveData : ISerializable
	{
		private CArray<gameGlobalTierSaveData> _globalTiers;

		[Ordinal(0)] 
		[RED("globalTiers")] 
		public CArray<gameGlobalTierSaveData> GlobalTiers
		{
			get
			{
				if (_globalTiers == null)
				{
					_globalTiers = (CArray<gameGlobalTierSaveData>) CR2WTypeManager.Create("array:gameGlobalTierSaveData", "globalTiers", cr2w, this);
				}
				return _globalTiers;
			}
			set
			{
				if (_globalTiers == value)
				{
					return;
				}
				_globalTiers = value;
				PropertySet(this);
			}
		}

		public gameTierSaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
