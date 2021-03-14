using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DataTerm : InteractiveDevice
	{
		private CHandle<gameFastTravelPointData> _linkedFastTravelPoint;
		private NodeRef _exitNode;
		private CHandle<FastTravelComponent> _fastTravelComponent;
		private CHandle<entIPlacedComponent> _lockColiderComponent;
		private gameNewMappinID _mappinID;
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;

		[Ordinal(93)] 
		[RED("linkedFastTravelPoint")] 
		public CHandle<gameFastTravelPointData> LinkedFastTravelPoint
		{
			get
			{
				if (_linkedFastTravelPoint == null)
				{
					_linkedFastTravelPoint = (CHandle<gameFastTravelPointData>) CR2WTypeManager.Create("handle:gameFastTravelPointData", "linkedFastTravelPoint", cr2w, this);
				}
				return _linkedFastTravelPoint;
			}
			set
			{
				if (_linkedFastTravelPoint == value)
				{
					return;
				}
				_linkedFastTravelPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("exitNode")] 
		public NodeRef ExitNode
		{
			get
			{
				if (_exitNode == null)
				{
					_exitNode = (NodeRef) CR2WTypeManager.Create("NodeRef", "exitNode", cr2w, this);
				}
				return _exitNode;
			}
			set
			{
				if (_exitNode == value)
				{
					return;
				}
				_exitNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("fastTravelComponent")] 
		public CHandle<FastTravelComponent> FastTravelComponent
		{
			get
			{
				if (_fastTravelComponent == null)
				{
					_fastTravelComponent = (CHandle<FastTravelComponent>) CR2WTypeManager.Create("handle:FastTravelComponent", "fastTravelComponent", cr2w, this);
				}
				return _fastTravelComponent;
			}
			set
			{
				if (_fastTravelComponent == value)
				{
					return;
				}
				_fastTravelComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("lockColiderComponent")] 
		public CHandle<entIPlacedComponent> LockColiderComponent
		{
			get
			{
				if (_lockColiderComponent == null)
				{
					_lockColiderComponent = (CHandle<entIPlacedComponent>) CR2WTypeManager.Create("handle:entIPlacedComponent", "lockColiderComponent", cr2w, this);
				}
				return _lockColiderComponent;
			}
			set
			{
				if (_lockColiderComponent == value)
				{
					return;
				}
				_lockColiderComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get
			{
				if (_mappinID == null)
				{
					_mappinID = (gameNewMappinID) CR2WTypeManager.Create("gameNewMappinID", "mappinID", cr2w, this);
				}
				return _mappinID;
			}
			set
			{
				if (_mappinID == value)
				{
					return;
				}
				_mappinID = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get
			{
				if (_isShortGlitchActive == null)
				{
					_isShortGlitchActive = (CBool) CR2WTypeManager.Create("Bool", "isShortGlitchActive", cr2w, this);
				}
				return _isShortGlitchActive;
			}
			set
			{
				if (_isShortGlitchActive == value)
				{
					return;
				}
				_isShortGlitchActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(99)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get
			{
				if (_shortGlitchDelayID == null)
				{
					_shortGlitchDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "shortGlitchDelayID", cr2w, this);
				}
				return _shortGlitchDelayID;
			}
			set
			{
				if (_shortGlitchDelayID == value)
				{
					return;
				}
				_shortGlitchDelayID = value;
				PropertySet(this);
			}
		}

		public DataTerm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
