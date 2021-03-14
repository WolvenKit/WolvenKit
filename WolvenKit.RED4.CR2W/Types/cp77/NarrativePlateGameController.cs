using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NarrativePlateGameController : gameuiProjectedHUDGameController
	{
		private inkWidgetReference _plateHolder;
		private CHandle<inkScreenProjection> _projection;
		private CHandle<gameIBlackboard> _narrativePlateBlackboard;
		private CUInt32 _narrativePlateBlackboardText;
		private wCHandle<NarrativePlateLogicController> _logicController;

		[Ordinal(9)] 
		[RED("plateHolder")] 
		public inkWidgetReference PlateHolder
		{
			get
			{
				if (_plateHolder == null)
				{
					_plateHolder = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "plateHolder", cr2w, this);
				}
				return _plateHolder;
			}
			set
			{
				if (_plateHolder == value)
				{
					return;
				}
				_plateHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("projection")] 
		public CHandle<inkScreenProjection> Projection
		{
			get
			{
				if (_projection == null)
				{
					_projection = (CHandle<inkScreenProjection>) CR2WTypeManager.Create("handle:inkScreenProjection", "projection", cr2w, this);
				}
				return _projection;
			}
			set
			{
				if (_projection == value)
				{
					return;
				}
				_projection = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("narrativePlateBlackboard")] 
		public CHandle<gameIBlackboard> NarrativePlateBlackboard
		{
			get
			{
				if (_narrativePlateBlackboard == null)
				{
					_narrativePlateBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "narrativePlateBlackboard", cr2w, this);
				}
				return _narrativePlateBlackboard;
			}
			set
			{
				if (_narrativePlateBlackboard == value)
				{
					return;
				}
				_narrativePlateBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("narrativePlateBlackboardText")] 
		public CUInt32 NarrativePlateBlackboardText
		{
			get
			{
				if (_narrativePlateBlackboardText == null)
				{
					_narrativePlateBlackboardText = (CUInt32) CR2WTypeManager.Create("Uint32", "narrativePlateBlackboardText", cr2w, this);
				}
				return _narrativePlateBlackboardText;
			}
			set
			{
				if (_narrativePlateBlackboardText == value)
				{
					return;
				}
				_narrativePlateBlackboardText = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("logicController")] 
		public wCHandle<NarrativePlateLogicController> LogicController
		{
			get
			{
				if (_logicController == null)
				{
					_logicController = (wCHandle<NarrativePlateLogicController>) CR2WTypeManager.Create("whandle:NarrativePlateLogicController", "logicController", cr2w, this);
				}
				return _logicController;
			}
			set
			{
				if (_logicController == value)
				{
					return;
				}
				_logicController = value;
				PropertySet(this);
			}
		}

		public NarrativePlateGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
