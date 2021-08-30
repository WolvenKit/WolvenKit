using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questShowHighlight_NodeSubType : questITutorial_NodeSubType
	{
		private gameEntityReference _entityReference;
		private CBool _enable;

		[Ordinal(0)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get => GetProperty(ref _entityReference);
			set => SetProperty(ref _entityReference, value);
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		public questShowHighlight_NodeSubType()
		{
			_enable = true;
		}
	}
}
