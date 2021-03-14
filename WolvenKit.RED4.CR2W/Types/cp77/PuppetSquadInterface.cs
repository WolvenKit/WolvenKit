using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PuppetSquadInterface : AICombatSquadScriptInterface
	{
		private wCHandle<gamedataAISquadParams_Record> _baseSquadRecord;
		private CArray<SquadTicketReceipt> _ticketHistory;
		private gameEnumNameToIndexCache _enumValueToNdx;
		private CBool _sectorsInitialized;

		[Ordinal(0)] 
		[RED("baseSquadRecord")] 
		public wCHandle<gamedataAISquadParams_Record> BaseSquadRecord
		{
			get
			{
				if (_baseSquadRecord == null)
				{
					_baseSquadRecord = (wCHandle<gamedataAISquadParams_Record>) CR2WTypeManager.Create("whandle:gamedataAISquadParams_Record", "baseSquadRecord", cr2w, this);
				}
				return _baseSquadRecord;
			}
			set
			{
				if (_baseSquadRecord == value)
				{
					return;
				}
				_baseSquadRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ticketHistory")] 
		public CArray<SquadTicketReceipt> TicketHistory
		{
			get
			{
				if (_ticketHistory == null)
				{
					_ticketHistory = (CArray<SquadTicketReceipt>) CR2WTypeManager.Create("array:SquadTicketReceipt", "ticketHistory", cr2w, this);
				}
				return _ticketHistory;
			}
			set
			{
				if (_ticketHistory == value)
				{
					return;
				}
				_ticketHistory = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("enumValueToNdx")] 
		public gameEnumNameToIndexCache EnumValueToNdx
		{
			get
			{
				if (_enumValueToNdx == null)
				{
					_enumValueToNdx = (gameEnumNameToIndexCache) CR2WTypeManager.Create("gameEnumNameToIndexCache", "enumValueToNdx", cr2w, this);
				}
				return _enumValueToNdx;
			}
			set
			{
				if (_enumValueToNdx == value)
				{
					return;
				}
				_enumValueToNdx = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("sectorsInitialized")] 
		public CBool SectorsInitialized
		{
			get
			{
				if (_sectorsInitialized == null)
				{
					_sectorsInitialized = (CBool) CR2WTypeManager.Create("Bool", "sectorsInitialized", cr2w, this);
				}
				return _sectorsInitialized;
			}
			set
			{
				if (_sectorsInitialized == value)
				{
					return;
				}
				_sectorsInitialized = value;
				PropertySet(this);
			}
		}

		public PuppetSquadInterface(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
