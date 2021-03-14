using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnDebugSymbols : CVariable
	{
		private CArray<scnPerformerSymbol> _performersDebugSymbols;
		private CArray<scnWorkspotSymbol> _workspotsDebugSymbols;
		private CArray<scnSceneEventSymbol> _sceneEventsDebugSymbols;
		private CArray<scnNodeSymbol> _sceneNodesDebugSymbols;

		[Ordinal(0)] 
		[RED("performersDebugSymbols")] 
		public CArray<scnPerformerSymbol> PerformersDebugSymbols
		{
			get
			{
				if (_performersDebugSymbols == null)
				{
					_performersDebugSymbols = (CArray<scnPerformerSymbol>) CR2WTypeManager.Create("array:scnPerformerSymbol", "performersDebugSymbols", cr2w, this);
				}
				return _performersDebugSymbols;
			}
			set
			{
				if (_performersDebugSymbols == value)
				{
					return;
				}
				_performersDebugSymbols = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("workspotsDebugSymbols")] 
		public CArray<scnWorkspotSymbol> WorkspotsDebugSymbols
		{
			get
			{
				if (_workspotsDebugSymbols == null)
				{
					_workspotsDebugSymbols = (CArray<scnWorkspotSymbol>) CR2WTypeManager.Create("array:scnWorkspotSymbol", "workspotsDebugSymbols", cr2w, this);
				}
				return _workspotsDebugSymbols;
			}
			set
			{
				if (_workspotsDebugSymbols == value)
				{
					return;
				}
				_workspotsDebugSymbols = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("sceneEventsDebugSymbols")] 
		public CArray<scnSceneEventSymbol> SceneEventsDebugSymbols
		{
			get
			{
				if (_sceneEventsDebugSymbols == null)
				{
					_sceneEventsDebugSymbols = (CArray<scnSceneEventSymbol>) CR2WTypeManager.Create("array:scnSceneEventSymbol", "sceneEventsDebugSymbols", cr2w, this);
				}
				return _sceneEventsDebugSymbols;
			}
			set
			{
				if (_sceneEventsDebugSymbols == value)
				{
					return;
				}
				_sceneEventsDebugSymbols = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("sceneNodesDebugSymbols")] 
		public CArray<scnNodeSymbol> SceneNodesDebugSymbols
		{
			get
			{
				if (_sceneNodesDebugSymbols == null)
				{
					_sceneNodesDebugSymbols = (CArray<scnNodeSymbol>) CR2WTypeManager.Create("array:scnNodeSymbol", "sceneNodesDebugSymbols", cr2w, this);
				}
				return _sceneNodesDebugSymbols;
			}
			set
			{
				if (_sceneNodesDebugSymbols == value)
				{
					return;
				}
				_sceneNodesDebugSymbols = value;
				PropertySet(this);
			}
		}

		public scnDebugSymbols(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
