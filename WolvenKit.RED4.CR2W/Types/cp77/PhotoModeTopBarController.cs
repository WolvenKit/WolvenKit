using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModeTopBarController : inkRadioGroupController
	{
		private CArray<inkWidgetReference> _photoModeTogglesArray;

		[Ordinal(5)] 
		[RED("photoModeTogglesArray")] 
		public CArray<inkWidgetReference> PhotoModeTogglesArray
		{
			get
			{
				if (_photoModeTogglesArray == null)
				{
					_photoModeTogglesArray = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "photoModeTogglesArray", cr2w, this);
				}
				return _photoModeTogglesArray;
			}
			set
			{
				if (_photoModeTogglesArray == value)
				{
					return;
				}
				_photoModeTogglesArray = value;
				PropertySet(this);
			}
		}

		public PhotoModeTopBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
