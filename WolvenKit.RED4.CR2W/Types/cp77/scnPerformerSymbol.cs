using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPerformerSymbol : CVariable
	{
		private scnPerformerId _performerId;
		private gameEntityReference _entityRef;
		private CRUID _editorPerformerId;

		[Ordinal(0)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get
			{
				if (_performerId == null)
				{
					_performerId = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "performerId", cr2w, this);
				}
				return _performerId;
			}
			set
			{
				if (_performerId == value)
				{
					return;
				}
				_performerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entityRef")] 
		public gameEntityReference EntityRef
		{
			get
			{
				if (_entityRef == null)
				{
					_entityRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "entityRef", cr2w, this);
				}
				return _entityRef;
			}
			set
			{
				if (_entityRef == value)
				{
					return;
				}
				_entityRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("editorPerformerId")] 
		public CRUID EditorPerformerId
		{
			get
			{
				if (_editorPerformerId == null)
				{
					_editorPerformerId = (CRUID) CR2WTypeManager.Create("CRUID", "editorPerformerId", cr2w, this);
				}
				return _editorPerformerId;
			}
			set
			{
				if (_editorPerformerId == value)
				{
					return;
				}
				_editorPerformerId = value;
				PropertySet(this);
			}
		}

		public scnPerformerSymbol(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
