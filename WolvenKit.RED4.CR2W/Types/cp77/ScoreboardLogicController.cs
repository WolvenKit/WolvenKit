using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScoreboardLogicController : inkWidgetLogicController
	{
		private CName _gridItem;
		private inkCompoundWidgetReference _namesWidget;
		private inkCompoundWidgetReference _scoresWidget;
		private CArray<ScoreboardPlayer> _highScores;

		[Ordinal(1)] 
		[RED("gridItem")] 
		public CName GridItem
		{
			get
			{
				if (_gridItem == null)
				{
					_gridItem = (CName) CR2WTypeManager.Create("CName", "gridItem", cr2w, this);
				}
				return _gridItem;
			}
			set
			{
				if (_gridItem == value)
				{
					return;
				}
				_gridItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("namesWidget")] 
		public inkCompoundWidgetReference NamesWidget
		{
			get
			{
				if (_namesWidget == null)
				{
					_namesWidget = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "namesWidget", cr2w, this);
				}
				return _namesWidget;
			}
			set
			{
				if (_namesWidget == value)
				{
					return;
				}
				_namesWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("scoresWidget")] 
		public inkCompoundWidgetReference ScoresWidget
		{
			get
			{
				if (_scoresWidget == null)
				{
					_scoresWidget = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "scoresWidget", cr2w, this);
				}
				return _scoresWidget;
			}
			set
			{
				if (_scoresWidget == value)
				{
					return;
				}
				_scoresWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("highScores")] 
		public CArray<ScoreboardPlayer> HighScores
		{
			get
			{
				if (_highScores == null)
				{
					_highScores = (CArray<ScoreboardPlayer>) CR2WTypeManager.Create("array:ScoreboardPlayer", "highScores", cr2w, this);
				}
				return _highScores;
			}
			set
			{
				if (_highScores == value)
				{
					return;
				}
				_highScores = value;
				PropertySet(this);
			}
		}

		public ScoreboardLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
