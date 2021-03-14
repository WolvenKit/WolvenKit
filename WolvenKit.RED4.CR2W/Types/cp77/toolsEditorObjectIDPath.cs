using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsEditorObjectIDPath : CVariable
	{
		private CArray<EditorObjectID> _elements;

		[Ordinal(0)] 
		[RED("elements")] 
		public CArray<EditorObjectID> Elements
		{
			get
			{
				if (_elements == null)
				{
					_elements = (CArray<EditorObjectID>) CR2WTypeManager.Create("array:EditorObjectID", "elements", cr2w, this);
				}
				return _elements;
			}
			set
			{
				if (_elements == value)
				{
					return;
				}
				_elements = value;
				PropertySet(this);
			}
		}

		public toolsEditorObjectIDPath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
