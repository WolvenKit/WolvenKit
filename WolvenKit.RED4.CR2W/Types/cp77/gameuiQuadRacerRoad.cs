using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiQuadRacerRoad : gameuiSideScrollerMiniGameDynObjectLogic
	{
		private inkQuadWidgetReference _roadQuad;
		private inkQuadWidgetReference _leftBackground;
		private inkQuadWidgetReference _rightBackground;
		private CArray<CName> _groundParts;
		private CArray<CName> _roadParts;

		[Ordinal(2)] 
		[RED("roadQuad")] 
		public inkQuadWidgetReference RoadQuad
		{
			get
			{
				if (_roadQuad == null)
				{
					_roadQuad = (inkQuadWidgetReference) CR2WTypeManager.Create("inkQuadWidgetReference", "roadQuad", cr2w, this);
				}
				return _roadQuad;
			}
			set
			{
				if (_roadQuad == value)
				{
					return;
				}
				_roadQuad = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("leftBackground")] 
		public inkQuadWidgetReference LeftBackground
		{
			get
			{
				if (_leftBackground == null)
				{
					_leftBackground = (inkQuadWidgetReference) CR2WTypeManager.Create("inkQuadWidgetReference", "leftBackground", cr2w, this);
				}
				return _leftBackground;
			}
			set
			{
				if (_leftBackground == value)
				{
					return;
				}
				_leftBackground = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rightBackground")] 
		public inkQuadWidgetReference RightBackground
		{
			get
			{
				if (_rightBackground == null)
				{
					_rightBackground = (inkQuadWidgetReference) CR2WTypeManager.Create("inkQuadWidgetReference", "rightBackground", cr2w, this);
				}
				return _rightBackground;
			}
			set
			{
				if (_rightBackground == value)
				{
					return;
				}
				_rightBackground = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("groundParts")] 
		public CArray<CName> GroundParts
		{
			get
			{
				if (_groundParts == null)
				{
					_groundParts = (CArray<CName>) CR2WTypeManager.Create("array:CName", "groundParts", cr2w, this);
				}
				return _groundParts;
			}
			set
			{
				if (_groundParts == value)
				{
					return;
				}
				_groundParts = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("roadParts")] 
		public CArray<CName> RoadParts
		{
			get
			{
				if (_roadParts == null)
				{
					_roadParts = (CArray<CName>) CR2WTypeManager.Create("array:CName", "roadParts", cr2w, this);
				}
				return _roadParts;
			}
			set
			{
				if (_roadParts == value)
				{
					return;
				}
				_roadParts = value;
				PropertySet(this);
			}
		}

		public gameuiQuadRacerRoad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
