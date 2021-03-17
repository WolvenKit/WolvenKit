using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkToggleController : inkButtonController
	{
		private inkToggleChangedCallback _toggleChanged;
		private CBool _isToggled;
		private CBool _autoToggleOnInput;

		[Ordinal(10)] 
		[RED("ToggleChanged")] 
		public inkToggleChangedCallback ToggleChanged
		{
			get => GetProperty(ref _toggleChanged);
			set => SetProperty(ref _toggleChanged, value);
		}

		[Ordinal(11)] 
		[RED("isToggled")] 
		public CBool IsToggled
		{
			get => GetProperty(ref _isToggled);
			set => SetProperty(ref _isToggled, value);
		}

		[Ordinal(12)] 
		[RED("autoToggleOnInput")] 
		public CBool AutoToggleOnInput
		{
			get => GetProperty(ref _autoToggleOnInput);
			set => SetProperty(ref _autoToggleOnInput, value);
		}

		public inkToggleController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
