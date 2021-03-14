using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NpcNameplateVisualData : CVariable
	{
		private gameuiNPCNextToTheCrosshair _npcNextToCrosshair;
		private CArray<gameuiBuffInfo> _buffList;
		private CArray<gameuiBuffInfo> _debuffList;

		[Ordinal(0)] 
		[RED("npcNextToCrosshair")] 
		public gameuiNPCNextToTheCrosshair NpcNextToCrosshair
		{
			get
			{
				if (_npcNextToCrosshair == null)
				{
					_npcNextToCrosshair = (gameuiNPCNextToTheCrosshair) CR2WTypeManager.Create("gameuiNPCNextToTheCrosshair", "npcNextToCrosshair", cr2w, this);
				}
				return _npcNextToCrosshair;
			}
			set
			{
				if (_npcNextToCrosshair == value)
				{
					return;
				}
				_npcNextToCrosshair = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("buffList")] 
		public CArray<gameuiBuffInfo> BuffList
		{
			get
			{
				if (_buffList == null)
				{
					_buffList = (CArray<gameuiBuffInfo>) CR2WTypeManager.Create("array:gameuiBuffInfo", "buffList", cr2w, this);
				}
				return _buffList;
			}
			set
			{
				if (_buffList == value)
				{
					return;
				}
				_buffList = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("debuffList")] 
		public CArray<gameuiBuffInfo> DebuffList
		{
			get
			{
				if (_debuffList == null)
				{
					_debuffList = (CArray<gameuiBuffInfo>) CR2WTypeManager.Create("array:gameuiBuffInfo", "debuffList", cr2w, this);
				}
				return _debuffList;
			}
			set
			{
				if (_debuffList == value)
				{
					return;
				}
				_debuffList = value;
				PropertySet(this);
			}
		}

		public NpcNameplateVisualData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
