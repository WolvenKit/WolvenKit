using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetRunnerChargesGameController : gameuiWidgetGameController
	{
		private inkTextWidgetReference _header;
		private inkCompoundWidgetReference _list;
		private inkWidgetReference _bar;
		private inkTextWidgetReference _value;
		private wCHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_PlayerBioMonitorDef> _bbDefinition;
		private CUInt32 _netrunnerCapacityId;
		private CHandle<redCallbackObject> _netrunnerCurrentId;
		private CInt32 _currentCharges;
		private CInt32 _maxCharges;
		private CArray<wCHandle<NetRunnerListItem>> _chargesList;
		private wCHandle<inkWidget> _root;

		[Ordinal(2)] 
		[RED("header")] 
		public inkTextWidgetReference Header
		{
			get => GetProperty(ref _header);
			set => SetProperty(ref _header, value);
		}

		[Ordinal(3)] 
		[RED("list")] 
		public inkCompoundWidgetReference List
		{
			get => GetProperty(ref _list);
			set => SetProperty(ref _list, value);
		}

		[Ordinal(4)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetProperty(ref _bar);
			set => SetProperty(ref _bar, value);
		}

		[Ordinal(5)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(6)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(7)] 
		[RED("bbDefinition")] 
		public CHandle<UI_PlayerBioMonitorDef> BbDefinition
		{
			get => GetProperty(ref _bbDefinition);
			set => SetProperty(ref _bbDefinition, value);
		}

		[Ordinal(8)] 
		[RED("netrunnerCapacityId")] 
		public CUInt32 NetrunnerCapacityId
		{
			get => GetProperty(ref _netrunnerCapacityId);
			set => SetProperty(ref _netrunnerCapacityId, value);
		}

		[Ordinal(9)] 
		[RED("netrunnerCurrentId")] 
		public CHandle<redCallbackObject> NetrunnerCurrentId
		{
			get => GetProperty(ref _netrunnerCurrentId);
			set => SetProperty(ref _netrunnerCurrentId, value);
		}

		[Ordinal(10)] 
		[RED("currentCharges")] 
		public CInt32 CurrentCharges
		{
			get => GetProperty(ref _currentCharges);
			set => SetProperty(ref _currentCharges, value);
		}

		[Ordinal(11)] 
		[RED("maxCharges")] 
		public CInt32 MaxCharges
		{
			get => GetProperty(ref _maxCharges);
			set => SetProperty(ref _maxCharges, value);
		}

		[Ordinal(12)] 
		[RED("chargesList")] 
		public CArray<wCHandle<NetRunnerListItem>> ChargesList
		{
			get => GetProperty(ref _chargesList);
			set => SetProperty(ref _chargesList, value);
		}

		[Ordinal(13)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		public NetRunnerChargesGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
