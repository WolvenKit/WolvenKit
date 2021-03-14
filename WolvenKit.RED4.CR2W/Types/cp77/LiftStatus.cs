using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LiftStatus : BaseDeviceStatus
	{
		private CName _libraryName;

		[Ordinal(26)] 
		[RED("libraryName")] 
		public CName LibraryName
		{
			get
			{
				if (_libraryName == null)
				{
					_libraryName = (CName) CR2WTypeManager.Create("CName", "libraryName", cr2w, this);
				}
				return _libraryName;
			}
			set
			{
				if (_libraryName == value)
				{
					return;
				}
				_libraryName = value;
				PropertySet(this);
			}
		}

		public LiftStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
