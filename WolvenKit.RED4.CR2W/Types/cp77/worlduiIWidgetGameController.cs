using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worlduiIWidgetGameController : inkIWidgetController
	{
		private TweakDBID _elementRecordID;

		[Ordinal(1)] 
		[RED("elementRecordID")] 
		public TweakDBID ElementRecordID
		{
			get => GetProperty(ref _elementRecordID);
			set => SetProperty(ref _elementRecordID, value);
		}

		public worlduiIWidgetGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
