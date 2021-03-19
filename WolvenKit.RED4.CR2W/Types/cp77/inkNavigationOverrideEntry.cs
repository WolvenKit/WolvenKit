using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkNavigationOverrideEntry : CVariable
	{
		private inkWidgetReference _from;
		private CEnum<inkDiscreteNavigationDirection> _direction;
		private inkWidgetReference _to;

		[Ordinal(0)] 
		[RED("from")] 
		public inkWidgetReference From
		{
			get => GetProperty(ref _from);
			set => SetProperty(ref _from, value);
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public CEnum<inkDiscreteNavigationDirection> Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		[Ordinal(2)] 
		[RED("to")] 
		public inkWidgetReference To
		{
			get => GetProperty(ref _to);
			set => SetProperty(ref _to, value);
		}

		public inkNavigationOverrideEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
