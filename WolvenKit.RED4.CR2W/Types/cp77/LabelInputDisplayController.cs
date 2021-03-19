using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LabelInputDisplayController : inkInputDisplayController
	{
		private inkTextWidgetReference _inputLabel;

		[Ordinal(11)] 
		[RED("inputLabel")] 
		public inkTextWidgetReference InputLabel
		{
			get => GetProperty(ref _inputLabel);
			set => SetProperty(ref _inputLabel, value);
		}

		public LabelInputDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
