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
			get => GetProperty(ref _photoModeTogglesArray);
			set => SetProperty(ref _photoModeTogglesArray, value);
		}

		public PhotoModeTopBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
