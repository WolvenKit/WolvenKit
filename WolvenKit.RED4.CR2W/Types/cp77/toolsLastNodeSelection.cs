using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsLastNodeSelection : CVariable
	{
		private CString _editorName;
		private toolsEditorObjectIDPath _selectedNodeIDPath;

		[Ordinal(0)] 
		[RED("editorName")] 
		public CString EditorName
		{
			get
			{
				if (_editorName == null)
				{
					_editorName = (CString) CR2WTypeManager.Create("String", "editorName", cr2w, this);
				}
				return _editorName;
			}
			set
			{
				if (_editorName == value)
				{
					return;
				}
				_editorName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("selectedNodeIDPath")] 
		public toolsEditorObjectIDPath SelectedNodeIDPath
		{
			get
			{
				if (_selectedNodeIDPath == null)
				{
					_selectedNodeIDPath = (toolsEditorObjectIDPath) CR2WTypeManager.Create("toolsEditorObjectIDPath", "selectedNodeIDPath", cr2w, this);
				}
				return _selectedNodeIDPath;
			}
			set
			{
				if (_selectedNodeIDPath == value)
				{
					return;
				}
				_selectedNodeIDPath = value;
				PropertySet(this);
			}
		}

		public toolsLastNodeSelection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
