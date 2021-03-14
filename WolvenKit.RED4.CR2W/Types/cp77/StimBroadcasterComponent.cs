using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimBroadcasterComponent : gameScriptableComponent
	{
		private CArray<CHandle<StimRequest>> _activeRequests;
		private CUInt32 _currentID;
		private CBool _shouldBroadcast;
		private CArray<NPCstubData> _targets;
		private CFloat _fallbackInterval;

		[Ordinal(5)] 
		[RED("activeRequests")] 
		public CArray<CHandle<StimRequest>> ActiveRequests
		{
			get
			{
				if (_activeRequests == null)
				{
					_activeRequests = (CArray<CHandle<StimRequest>>) CR2WTypeManager.Create("array:handle:StimRequest", "activeRequests", cr2w, this);
				}
				return _activeRequests;
			}
			set
			{
				if (_activeRequests == value)
				{
					return;
				}
				_activeRequests = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("currentID")] 
		public CUInt32 CurrentID
		{
			get
			{
				if (_currentID == null)
				{
					_currentID = (CUInt32) CR2WTypeManager.Create("Uint32", "currentID", cr2w, this);
				}
				return _currentID;
			}
			set
			{
				if (_currentID == value)
				{
					return;
				}
				_currentID = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("shouldBroadcast")] 
		public CBool ShouldBroadcast
		{
			get
			{
				if (_shouldBroadcast == null)
				{
					_shouldBroadcast = (CBool) CR2WTypeManager.Create("Bool", "shouldBroadcast", cr2w, this);
				}
				return _shouldBroadcast;
			}
			set
			{
				if (_shouldBroadcast == value)
				{
					return;
				}
				_shouldBroadcast = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("targets")] 
		public CArray<NPCstubData> Targets
		{
			get
			{
				if (_targets == null)
				{
					_targets = (CArray<NPCstubData>) CR2WTypeManager.Create("array:NPCstubData", "targets", cr2w, this);
				}
				return _targets;
			}
			set
			{
				if (_targets == value)
				{
					return;
				}
				_targets = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("fallbackInterval")] 
		public CFloat FallbackInterval
		{
			get
			{
				if (_fallbackInterval == null)
				{
					_fallbackInterval = (CFloat) CR2WTypeManager.Create("Float", "fallbackInterval", cr2w, this);
				}
				return _fallbackInterval;
			}
			set
			{
				if (_fallbackInterval == value)
				{
					return;
				}
				_fallbackInterval = value;
				PropertySet(this);
			}
		}

		public StimBroadcasterComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
