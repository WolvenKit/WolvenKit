using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedamageServerKillData : IScriptable
	{
		private CUInt32 _id;
		private gameuiKillInfo _killInfo;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt32) CR2WTypeManager.Create("Uint32", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("killInfo")] 
		public gameuiKillInfo KillInfo
		{
			get
			{
				if (_killInfo == null)
				{
					_killInfo = (gameuiKillInfo) CR2WTypeManager.Create("gameuiKillInfo", "killInfo", cr2w, this);
				}
				return _killInfo;
			}
			set
			{
				if (_killInfo == value)
				{
					return;
				}
				_killInfo = value;
				PropertySet(this);
			}
		}

		public gamedamageServerKillData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
