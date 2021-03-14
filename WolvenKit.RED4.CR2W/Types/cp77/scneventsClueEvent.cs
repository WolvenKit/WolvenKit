using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsClueEvent : scnSceneEvent
	{
		private gameEntityReference _clueEntity;
		private CBool _markedOnTimeline;
		private CName _clueName;
		private CEnum<gameuiEBraindanceLayer> _layer;
		private CBool _overrideFact;
		private CName _factName;

		[Ordinal(6)] 
		[RED("clueEntity")] 
		public gameEntityReference ClueEntity
		{
			get
			{
				if (_clueEntity == null)
				{
					_clueEntity = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "clueEntity", cr2w, this);
				}
				return _clueEntity;
			}
			set
			{
				if (_clueEntity == value)
				{
					return;
				}
				_clueEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("markedOnTimeline")] 
		public CBool MarkedOnTimeline
		{
			get
			{
				if (_markedOnTimeline == null)
				{
					_markedOnTimeline = (CBool) CR2WTypeManager.Create("Bool", "markedOnTimeline", cr2w, this);
				}
				return _markedOnTimeline;
			}
			set
			{
				if (_markedOnTimeline == value)
				{
					return;
				}
				_markedOnTimeline = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("clueName")] 
		public CName ClueName
		{
			get
			{
				if (_clueName == null)
				{
					_clueName = (CName) CR2WTypeManager.Create("CName", "clueName", cr2w, this);
				}
				return _clueName;
			}
			set
			{
				if (_clueName == value)
				{
					return;
				}
				_clueName = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("layer")] 
		public CEnum<gameuiEBraindanceLayer> Layer
		{
			get
			{
				if (_layer == null)
				{
					_layer = (CEnum<gameuiEBraindanceLayer>) CR2WTypeManager.Create("gameuiEBraindanceLayer", "layer", cr2w, this);
				}
				return _layer;
			}
			set
			{
				if (_layer == value)
				{
					return;
				}
				_layer = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("overrideFact")] 
		public CBool OverrideFact
		{
			get
			{
				if (_overrideFact == null)
				{
					_overrideFact = (CBool) CR2WTypeManager.Create("Bool", "overrideFact", cr2w, this);
				}
				return _overrideFact;
			}
			set
			{
				if (_overrideFact == value)
				{
					return;
				}
				_overrideFact = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("factName")] 
		public CName FactName
		{
			get
			{
				if (_factName == null)
				{
					_factName = (CName) CR2WTypeManager.Create("CName", "factName", cr2w, this);
				}
				return _factName;
			}
			set
			{
				if (_factName == value)
				{
					return;
				}
				_factName = value;
				PropertySet(this);
			}
		}

		public scneventsClueEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
