using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsPingSystemMappin : gamemappinsRuntimeMappin
	{
		private CEnum<gamedataPingType> _pingType;

		[Ordinal(0)] 
		[RED("pingType")] 
		public CEnum<gamedataPingType> PingType
		{
			get
			{
				if (_pingType == null)
				{
					_pingType = (CEnum<gamedataPingType>) CR2WTypeManager.Create("gamedataPingType", "pingType", cr2w, this);
				}
				return _pingType;
			}
			set
			{
				if (_pingType == value)
				{
					return;
				}
				_pingType = value;
				PropertySet(this);
			}
		}

		public gamemappinsPingSystemMappin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
