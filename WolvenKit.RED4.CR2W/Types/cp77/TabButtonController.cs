using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TabButtonController : inkToggleController
	{
		private inkTextWidgetReference _label;
		private inkImageWidgetReference _icon;
		private CInt32 _data;
		private CString _labelSet;
		private CString _iconSet;

		[Ordinal(13)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(14)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(15)] 
		[RED("data")] 
		public CInt32 Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(16)] 
		[RED("labelSet")] 
		public CString LabelSet
		{
			get => GetProperty(ref _labelSet);
			set => SetProperty(ref _labelSet, value);
		}

		[Ordinal(17)] 
		[RED("iconSet")] 
		public CString IconSet
		{
			get => GetProperty(ref _iconSet);
			set => SetProperty(ref _iconSet, value);
		}

		public TabButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
