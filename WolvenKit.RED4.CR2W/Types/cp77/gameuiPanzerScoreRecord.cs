using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerScoreRecord : inkWidgetLogicController
	{
		private inkTextWidgetReference _nameWidget;
		private inkTextWidgetReference _scoreWidget;

		[Ordinal(1)] 
		[RED("nameWidget")] 
		public inkTextWidgetReference NameWidget
		{
			get => GetProperty(ref _nameWidget);
			set => SetProperty(ref _nameWidget, value);
		}

		[Ordinal(2)] 
		[RED("scoreWidget")] 
		public inkTextWidgetReference ScoreWidget
		{
			get => GetProperty(ref _scoreWidget);
			set => SetProperty(ref _scoreWidget, value);
		}

		public gameuiPanzerScoreRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
