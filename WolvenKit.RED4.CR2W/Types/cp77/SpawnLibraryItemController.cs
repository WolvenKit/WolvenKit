using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpawnLibraryItemController : inkWidgetLogicController
	{
		private CName _libraryID;

		[Ordinal(1)] 
		[RED("libraryID")] 
		public CName LibraryID
		{
			get
			{
				if (_libraryID == null)
				{
					_libraryID = (CName) CR2WTypeManager.Create("CName", "libraryID", cr2w, this);
				}
				return _libraryID;
			}
			set
			{
				if (_libraryID == value)
				{
					return;
				}
				_libraryID = value;
				PropertySet(this);
			}
		}

		public SpawnLibraryItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
